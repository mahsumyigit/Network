using Microsoft.EntityFrameworkCore;

namespace network
{
    public static class NetworkDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id = 4,
                Name = "ali",
                CategoryId = 1,

            },
            new Team
            {
                Id = 3,
                Name = "ahmet",
                CategoryId = 2,
            }
        );
            modelBuilder.Entity<TeamDetails>().HasData(
                       new TeamDetails
                       {
                           Id = 4,
                           Description = "ali is good partner",
                           Salary = 5000,
                           StartingDate = "10.04.2022",
                           EndingDate = "10.06.2022"

                       },
                       new TeamDetails
                       {
                           Id = 3,
                           Description = "ahmet is good partner",
                           Salary = 5000,
                           StartingDate = "10.04.2022",
                           EndingDate = "10.06.2022"
                       }
                   );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    lesson = Category.Lesson.dance
                },
                new Category
                  {
                    CategoryId = 2,
                    lesson = Category.Lesson.sport
                }
            );

        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.CategoryId);

            });
            modelBuilder.Entity<TeamDetails>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Description);
                entity.Property(e => e.Salary);
                entity.Property(e => e.StartingDate);
                entity.Property(c => c.EndingDate);
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                entity.Property(e => e.lesson);
            });
            SetDataToDB(modelBuilder);
        }

    }
}