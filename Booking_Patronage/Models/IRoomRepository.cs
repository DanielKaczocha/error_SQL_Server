using System.Collections.Generic;

namespace Booking_Patronage.Models
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();
        Room GetRoomId(int roomId);
    }
}
