using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework_deneme.Core
{
    public class BaseEntity
    {
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsActive{ get; set; }
    }
}
