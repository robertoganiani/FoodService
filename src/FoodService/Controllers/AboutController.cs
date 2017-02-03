using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodService.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "598 111 521";
        }

        public string Address()
        {
            return "Tbilisi, Georgia";
        }
    }
}
