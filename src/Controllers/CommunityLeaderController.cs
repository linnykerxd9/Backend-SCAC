using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Controllers
{
    public class CommunityLeaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
