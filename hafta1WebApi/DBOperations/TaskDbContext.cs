

using Microsoft.EntityFrameworkCore;

namespace hafta1WebApi.DBOperations
{
    public class TaskDbContext :DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options):base(options)
        { }
        public DbSet<Task> Tasks { get; set; }


    }
}
