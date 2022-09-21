using Students.DataAccess.DBContexts;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.DataAccess.Repositories
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(StudentsContext ctx) : base(ctx)
        {

        }
    }
}
