using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {
            //mesajlı olan ctor
        }
        public ErrorResult() : base(false)
        {
            //mesajsız ctor
        }
    }
}
