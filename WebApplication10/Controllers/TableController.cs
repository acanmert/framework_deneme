using framework_deneme.Dal;
using framework_deneme.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class TableController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(GetCategory());
        }
        public static List<CategoryViewModel> GetSampleCategories()
        {
            // Örnek kategoriler oluştur
            var categories = new List<CategoryViewModel>
            {
                new CategoryViewModel
                {
                    Id = 1,
                    Name = "Category 1",
                    Description = "Description for Category 1",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "Note for Category 1",
                    CreatedDate = DateTime.Now.AddDays(-10),
                    CreatedByName = "Admin",
                    ModifiedDate = DateTime.Now.AddDays(-5),
                    ModifiedByName = "Admin"
                },
                new CategoryViewModel
                {
                    Id = 2,
                    Name = "Category 2",
                    Description = "Description for Category 2",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "Note for Category 2",
                    CreatedDate = DateTime.Now.AddDays(-8),
                    CreatedByName = "Admin",
                    ModifiedDate = DateTime.Now.AddDays(-3),
                    ModifiedByName = "Admin"
                },
                new CategoryViewModel
                {
                    Id = 3,
                    Name = "Category 3",
                    Description = "Description for Category 3",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "Note for Category 3",
                    CreatedDate = DateTime.Now.AddDays(-5),
                    CreatedByName = "Admin",
                    ModifiedDate = DateTime.Now.AddDays(-1),
                    ModifiedByName = "Admin"
                }
            };

            return categories;
        }
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");
        }
        public void AddCategory()
        {
           
                UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
                unitOfWork.CategoryRepository.Add(new Category
                {
              
                    Name = "Eklencek 1",
                    Description = "Description for Category 1",
                    IsActive = true,
                    IsDeleted = false,
                    Note = "Note for Category 1",
                    CreatedDate = DateTime.Now.AddDays(-10),
                    CreatedByName = "Admin",
                    ModifiedDate = DateTime.Now.AddDays(-5),
                    ModifiedByName = "Admin"
                });
               unitOfWork.Complete();
            
        }
        public List<Category> GetCategory()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            return unitOfWork.CategoryRepository.GetAll().ToList();
        }
    }
}
