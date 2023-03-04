using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace awesomeMVC
{
    public class PublicController : Controller
    {
        public String Index()
        {
            return "Hello From Public Page";
        }
    }
}
