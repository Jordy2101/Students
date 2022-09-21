using Students.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Domain.Students
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime CreateDate { get; set; } 
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
