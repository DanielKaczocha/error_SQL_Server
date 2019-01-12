using System.Linq;

namespace Booking_Patronage.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Rooms.Any())
            {
                context.AddRange(
                    new Room
                    {
                        imgUrl = "/images/huge.png",
                        number = 100,
                        name = "White Room",
                        floor = 0,
                        maxOverload = 75,
                        projector = true,
                        inforamtion = "Pokoj z łatwym dostępem."
                    },
                    new Room
                    {
                        imgUrl = "/images/medium.png",
                        number = 110,
                        name = "Beige Room",
                        floor = 0,
                        maxOverload = 50,
                        projector = false,
                        inforamtion = "Spokojny pokoj."
                    },
                      new Room
                      {
                          imgUrl = "/images/small.png",
                          number = 310,
                          name = "Black Room",
                          floor = 2,
                          maxOverload = 25,
                          projector = true,
                          inforamtion = "Pokoj z planetarium."
                      }                     
                    );
            }
            context.SaveChanges();

        }
    }
}
