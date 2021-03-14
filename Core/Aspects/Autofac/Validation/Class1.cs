using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class Class1
    {
        public class ValidationAspect : MethodInterception
        // MethodInterception u using Core.Utilities.Interceptors içinden çöz
        {
            private Type _validatorType;
            public ValidationAspect(Type validatorType)
            {
                if (!typeof(IValidator).IsAssignableFrom(validatorType))
                // IValidator u using FluentValidation; dan çöz.
                {
                    throw new System.Exception("Bu bir doğrulama sınıfı değil");
                    //throw new System.Exception(AspectMessages.WrongValidationType);
                    // bu hatayı geçici olarak bu şekilde düzenledik.
                }

                _validatorType = validatorType;
            }
            protected override void OnBefore(IInvocation invocation)
            // IInvocation u using Castle.Dynamic.Proxy; den çöz
            {
                var validator = (IValidator)Activator.CreateInstance(_validatorType);
                // Bu satır reflection
                var entityType = _validatorType.BaseType.GetGenericArguments()[0];
                var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
                // Where i using System.Linq; ten çöz
                foreach (var entity in entities)
                {
                    ValidationTool.Validate(validator, entity);
                    // ValidationTool u using Core.CrossCuttingConserns.Validation; dan çöz
                }
            }
        }
    }
}
