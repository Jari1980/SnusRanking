using Microsoft.AspNetCore.Components.Sections;
using Microsoft.EntityFrameworkCore;
using SnusRanking.Data;

namespace SnusRanking.Models
{
    public class SeedSnusData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Snus.Any())
                {
                    Console.WriteLine("mmm not right");
                    return;
                }

                context.Snus.AddRange(
                    new Snus
                    {
                        Name = "General Orginal",
                        Type = "Portion",
                        Flavor = "Rich and flavorfull tobaccocharacter with a hint of bergamott, dried weed, leather and tee"
                    },
                    new Snus
                    {
                        Name = "General Orginal White",
                        Type = "Portion",
                        Flavor = "Rich and flavorfull tobaccocharacter with a hint of bergamott, dried weed, leather and tee"
                    },
                    new Snus
                    {
                        Name = "Kronan",
                        Type = "Portion",
                        Flavor = "Rich tobaccocharacter with hint of viol, citrus and green herbs"
                    },
                    new Snus
                    {
                        Name = "Kronan White",
                        Type = "Portion",
                        Flavor = "Rich tobaccocharacter with hint of viol, citrus and green herbs"
                    },
                    new Snus
                    {
                        Name = "Kapten White",
                        Type = "Portion",
                        Flavor = "Tobacco and bergamott"
                    },
                    new Snus
                    {
                        Name = "Ettan",
                        Type = "Portion",
                        Flavor = "Tobacco, smoke, malt and a hint of dark chocolate"
                    },
                    new Snus
                    {
                        Name = "Grov",
                        Type = "Portion",
                        Flavor = "Rich tobacco with geranium, dried herbs, nuts and tar"
                    },
                    new Snus
                    {
                        Name = "Kaliber",
                        Type = "Portion",
                        Flavor = "Tobacco with hint of citrus, herbs and pomegranate"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
