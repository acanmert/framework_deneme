using System;

namespace framework_deneme.Core
{
    public class Personnel: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
