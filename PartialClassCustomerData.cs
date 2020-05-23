using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoreCsharpWebApp
{
    public partial class PartialClassCustomer
    {
        public PartialClassCustomer()
        {
            FirstName = "Xavier";
            LastName = "Fernando";
            PartialMethod();        //This gets skipped because we do not have any implementation
        }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        partial void PartialMethod();
    }
}