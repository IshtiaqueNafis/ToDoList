using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        public ToDoContext Context { get; set; }

        public HomeController(ToDoContext context) => Context = context;//construector; 

    }
}