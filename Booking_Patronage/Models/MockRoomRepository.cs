using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Patronage.Models
{
    public class MockRoomRepository : IRoomRepository
    {
        private List<Room> rooms;

        public MockRoomRepository()
        {
            if(rooms == null)
            {
                ReloadRooms();
            }
        }

        private void ReloadRooms()
        {
            rooms = new List<Room>
           {
               new Room
               {
                    id = 1,
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
                    id = 2,
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
                    id = 3,
                    imgUrl = "/images/small.png",
                    number = 310,
                    name = "Black Room",
                    floor = 2,
                    maxOverload = 25,
                    projector = true,
                    inforamtion = "Pokoj z planetarium."
               }

           };
        }

        IEnumerable<Room> IRoomRepository.GetAllRooms()
        {
            return rooms;
        }

        Room IRoomRepository.GetRoomId(int roomId)
        {
            return rooms.FirstOrDefault(s => s.id == roomId);
        }
    }
}
