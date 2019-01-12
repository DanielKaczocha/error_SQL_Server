using System.Collections.Generic;
using System.Linq;

namespace Booking_Patronage.Models
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _appDbContext;

        public RoomRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _appDbContext.Rooms;
        }

        public Room GetRoomId(int roomId)
        {
            return _appDbContext.Rooms.FirstOrDefault(s => s.id == roomId);
        }
    }
}
