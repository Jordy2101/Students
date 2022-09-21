using Microsoft.EntityFrameworkCore;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.DataAccess.DBContexts
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
    }
}
