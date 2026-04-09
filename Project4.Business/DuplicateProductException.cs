using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Project4.Business
{
    // we create our exception 
    public class DuplicateProductException : Exception
    {
        //we want to create our exception message . So we use the Exception as interface and than we use exception's Message property.
        //fistly we giving a message veriable as string type and later we giving Excpetion's Message property to our exception.
        public DuplicateProductException(string message):base(message)
        {
            
        }
    }
}
