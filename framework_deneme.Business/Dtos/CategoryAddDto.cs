using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Business.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} Bos gecilmez")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakteden büyük olamaz")]
        [MinLength(3, ErrorMessage = "{0} {1} karakteden az olamaz")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakteden büyük olamaz")]
        [MinLength(3, ErrorMessage = "{0} {1} karakteden az olamaz")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakteden büyük olamaz")]
        [MinLength(3, ErrorMessage = "{0} {1} karakteden az olamaz")]
        public string Note { get; set; }
        [Required(ErrorMessage = "{0} Bos gecilmez")]
        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }
    }
}
