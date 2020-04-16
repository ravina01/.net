using Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerCloud.Repository
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=FinalExam;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<DotnetClassEntity> dotnetClass { get; set; }
        public DbSet<InstructorEntity> instructors { get; set; }
       
    }
}
