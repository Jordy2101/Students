using Students.Application.Filters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Filters
{
    public class StudentsFilter : BaseFilter
    {
        public string keywrod { get; set; }
    }
}
