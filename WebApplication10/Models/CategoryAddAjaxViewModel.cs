using framework_deneme.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace framework_deneme.UI.Models
{
    public class CategoryAddAjaxViewModel
    {
        public CategoryAddDto categoryAddDto { get; set; }
        public string CategoryAddPartial { get; set; }
        public CategoryDto CategoryDto{ get; set; }
    }
}
