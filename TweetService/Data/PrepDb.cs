using TweetService.Models;

namespace TweetService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {
            if (!context.Tweets.Any())
            {
                Console.WriteLine("--> Seeding Data...");
                context.Tweets.AddRange(
                    new Tweet() { Message = "Dot Net", User = "Microsoft", Like = 0, DateTime = "12/10/2022" },
                    new Tweet() { Message = "My First Tweet", User = "Bob", Like = 0, DateTime = "19/03/2021" },
                    new Tweet() { Message = "How Why When", User = "Tim", Like = 0, DateTime = "01/01/2023" },
                    new Tweet() { Message = "Test", User = "Mia", Like = 0, DateTime = "5/09/2023" }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}