using System;
using helloWorldAPI.Controllers;
using helloWorldAPI.Models;

namespace helloWorldAPI.Interfaces
{
    public class StringGreeter : IGreeter
    {
        public StringGreeter()
        {
        }

        public HelloWorld Greet()
        {

            return new HelloWorld { Data = "Hello World!" };
            //throw new NotImplementedException();
        }
    }
}
