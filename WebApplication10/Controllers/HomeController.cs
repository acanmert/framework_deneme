using framework_deneme.Core;
using framework_deneme.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
        
            return View();
        }
        public void Add()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository.Add(new Department {  CreatedTime = DateTime.Now, Name = "Bilgi İşlem" });
            unitOfWork.Complete();
        }
        public void Get()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            var deneme=unitOfWork.DepartmentRepository.GetAll();

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
