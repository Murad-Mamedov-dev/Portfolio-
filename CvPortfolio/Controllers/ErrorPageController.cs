using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CvPortfolio.Controllers
{

    public class ErrorPageController : Controller
    {
      
      
        public IActionResult Index(int statusCode)
        {


            return this.View();
        }
    }
}