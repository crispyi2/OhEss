using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace OhEss.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AccountData(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AccountData>>()))
            {
                // Look for any movies.
                if (context.Account.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Account
                    {
                        Username = "root",
                        Password = "root",
						DateCreated = DateTime.Parse("2021-4-14"),
                        StoragePath = "~/Data/users/root",
                        LastLoggedIn = DateTime.Parse("2021-4-14"),
						ProfilePicturePath = "~/Data/users/root/pfp/root.png"
                    },
                context.SaveChanges();
            }
        }
    }
}