using Microsoft.EntityFrameworkCore;
using System.Linq;
using BuildingRestAPI.Context;
using BuildingRestAPI.Modles;
namespace BuildingRestAPI.Seeds
{
    public static class SeedData
    {
        public static void SeedDatabase(BuildingDbContext context)
        {
            context.Database.Migrate();
            if(context.Buildings.Count() == 0)
            {
                context.AddRange(
                    new Building { Name = "First", Description = "The first building", Location = "Main", Number = 100, ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.gBRzG71aa1f6dy_MuGUwOAHaEo%26pid%3DApi&f=1" },
                    new Building { Name = "Second", Description = "The second building", Location = "Main", Number = 200, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Green_Building_-_MIT%2C_Cambridge%2C_MA_-_DSC05589.jpg/1200px-Green_Building_-_MIT%2C_Cambridge%2C_MA_-_DSC05589.jpg" },
                    new Building { Name = "Third", Description = "The third building", Location = "Side", Number = 10, ImageUrl = "https://c.pxhere.com/photos/60/32/architecture_tower_building_towers_red_brown_low_angle_shot_blue_sky-1401639.jpg!d" },
                    new Building { Name = "Firth", Description = "The firth building", Location = "Main", Number = 300, ImageUrl = "https://www.publicdomainpictures.net/pictures/20000/nahled/tall-office-building-871299859831cWx.jpg" },
                    new Building { Name = "Fifth", Description = "The fifth building", Location = "Side", Number = 20, ImageUrl = "https://wonderfulengineering.com/wp-content/uploads/2014/01/beautiful-wallpaper-39.jpg" },
                    new Building { Name = "Sixth", Description = "The sixth building", Location = "Main", Number = 400, ImageUrl = "http://cdn.homesthetics.net/wp-content/uploads/2015/10/52-Of-The-Most-Famous-Buildings-In-The-World-That-Are-Known-For-Their-Unconventional-Architectural-Structure-11.jpg" },
                    new Building { Name = "Seventh", Description = "The seventh building", Location = "Main", Number = 500, ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.on8__7l0en8mg_q2IB-mYQHaKf%26pid%3DApi&f=1" },
                    new Building { Name = "eight", Description = "The eigth building", Location = "Side", Number = 30, ImageUrl = "https://images.skyscrapercenter.com/building/aoncenter_overall8_mg.jpg" },
                    new Building { Name = "ninth", Description = "The ninth building", Location = "Side", Number = 40, ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.JuwmIpr5s02mTir94B1gQAHaEK%26pid%3DApi&f=1" },
                    new Building { Name = "ten", Description = "The ten building", Location = "Side", Number = 50, ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.6MIoyeRDXb989CBJXdGpIAHaJ3%26pid%3DApi&f=1" }
                    );
                context.SaveChanges();
            }
        }
    }
}
