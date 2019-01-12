using Booking_Patronage.Models;
using Booking_Patronage.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking_Patronage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public HomeController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var rooms = _roomRepository.GetAllRooms().OrderBy(s => s.maxOverload);
            var homeVM = new HomeVM()
            {
                Name = "Lista pokoi",
                Rooms = rooms.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Szczegoly(int id)
        {
            var room = _roomRepository.GetRoomId(id);

            if (room == null)
                return NotFound();

            return View(room);
        }
    }
}
