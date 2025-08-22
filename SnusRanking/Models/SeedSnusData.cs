using Microsoft.AspNetCore.Components.Sections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SnusRanking.Data;
using static System.Net.Mime.MediaTypeNames;

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
                    Flavor = "Rich and flavorfull tobaccocharacter with a hint of bergamott, dried weed, leather and tee",
                    Pic = File.ReadAllBytes("wwwroot/images/GeneralOrginal.png")
                },
                new Snus
                {
                    Name = "General Orginal White",
                    Type = "Portion",
                    Flavor = "Rich and flavorfull tobaccocharacter with a hint of bergamott, dried weed, leather and tee",
                    Pic = File.ReadAllBytes("wwwroot/images/GeneralOrginalWhite.png")
                },
                new Snus
                {
                    Name = "Kronan",
                    Type = "Portion",
                    Flavor = "Rich tobaccocharacter with hint of viol, citrus and green herbs",
                    Pic = File.ReadAllBytes("wwwroot/images/Kronan.png")
                },
                new Snus
                {
                    Name = "Kronan White",
                    Type = "Portion",
                    Flavor = "Rich tobaccocharacter with hint of viol, citrus and green herbs",
                    Pic = File.ReadAllBytes("wwwroot/images/KronanWhite.png")
                },
                new Snus
                {
                    Name = "Kapten",
                    Type = "Portion",
                    Flavor = "Tobacco and bergamott",
                    Pic = File.ReadAllBytes("wwwroot/images/Kapten.png")
                },
                new Snus
                {
                    Name = "Ettan",
                    Type = "Portion",
                    Flavor = "Tobacco, smoke, malt and a hint of dark chocolate",
                    Pic = File.ReadAllBytes("wwwroot/images/Ettan.png")
                },
                new Snus
                {
                    Name = "Grov",
                    Type = "Portion",
                    Flavor = "Rich tobacco with geranium, dried herbs, nuts and tar",
                    Pic = File.ReadAllBytes("wwwroot/images/Grov.png")
                },
                new Snus
                {
                    Name = "Kaliber",
                    Type = "Portion",
                    Flavor = "Tobacco with hint of citrus, herbs and pomegranate",
                    Pic = File.ReadAllBytes("wwwroot/images/Kaliber.png")
                }
                 );

                context.SaveChanges();
            }
        }
    }
}
