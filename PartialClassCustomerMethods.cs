using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoreCsharpWebApp
{
    public partial class PartialClassCustomer
    {
        public string Print()
        {
            return FirstName + " " + LastName + "<br>";
        }

        //can be compiled with or without a partial method
        //partial void PartialMethod()
        //{
        //}
    }
}