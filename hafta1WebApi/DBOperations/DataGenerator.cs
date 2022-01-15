using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace hafta1WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using ( var context = new TaskDbContext(serviceProvider.GetRequiredService<DbContextOptions<TaskDbContext>>()))
            {
                if (context.Tasks.Any())
                {
                    return;
                }

                context.Tasks.AddRange(
                     new Task
                     {
                         //Id = 1,
                         Title = "Patika Dersleri",
                         Description = ".Net patikasını takip et",
                         Status = Status.getStatus()[0],
                         Date = new DateTime(2022, 01, 22)


                     },
                     new Task
                     {
                         //Id = 2,
                         Title = "Office Hours ",
                         Description = "Perşembe günü office hours katıp 20:00",
                         Status = Status.getStatus()[1],
                         Date = new DateTime(2022, 01, 13)

                     },
                     new Task
                     {
                         //Id = 3,
                         Title = "Ödev",
                         Description = "Haft 1 ödevini yap!",
                         Status = Status.getStatus()[0],
                         Date = new DateTime(2022, 01, 15)
                     },
                     new Task
                     {
                         //Id = 4,
                         Title = "Oyun",
                         Description = "Oyun oyna",
                         Status = Status.getStatus()[0],
                         Date = new DateTime(2022, 01, 14)
                     }
                        );
                context.SaveChanges();
            }
        }
    }
}
