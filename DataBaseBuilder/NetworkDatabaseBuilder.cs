using Microsoft.EntityFrameworkCore;
using Enum;


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
                Name = "ali"

            },
            new Team
            {
                Id = 3,
                Name = "ahmet"
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
                    Id = 2,
                    Lessons=Lesson.yoga
                },
                new Category
                  {
                    Id = 1,
                    Lessons=Lesson.dance
                }
            );

        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.HasOne(e=>e.TeamDetails).WithOne(e=>e.Teams).HasForeignKey<Team>("TeamDetailsId");

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
                entity.HasKey(e => e.Id);
                entity.Property(e=>e.Lessons);
                entity.HasOne(e => e.TeamDetails).WithMany(e=>e.Categories).HasForeignKey(e=>e.TeamDetailsId);

            });
            SetDataToDB(modelBuilder);
        }

    }
}