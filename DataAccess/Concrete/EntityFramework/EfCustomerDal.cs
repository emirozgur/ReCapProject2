using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfCustomerDal : EfEntityRepositoryBase<Customer, GalleryContext>, ICustomerDal
    {
        // Burada customer tablosu ile diğer tabloların join kodları olacak
        public List<CustomerDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
