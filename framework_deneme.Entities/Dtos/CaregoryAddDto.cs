using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Entities.Dtos
{
    public class CaregoryAddDto
    {
  
        public string Name { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public bool IsActive { get; set; }
    }
}
