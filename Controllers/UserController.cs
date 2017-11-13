using Microsoft.AspNetCore.Mvc;
// using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace portfolio.Controllers {
    public class UserController : Controller {
        
        [HttpGet]
        [Route("")]
        public IActionResult Home(){
                
                return View("Home");
        }
    
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact(){
            
            return View("Contact");

        }

        [HttpGet]
        [Route("projects")]
        public IActionResult Projects(){

            return View("Projects");
        }
    }    
}