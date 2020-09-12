using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelWebsite.Data;
using HotelWebsite.Models;

namespace HotelWebsite.Pages.Rooms
{
    public class IndexModel : PageModel
    {
        private readonly HotelWebsite.Data.HotelWebsiteContext _context;

        public IndexModel(HotelWebsite.Data.HotelWebsiteContext context)
        {
            _context = context;
        }

        public IList<Room> Room { get;set; }

        public async Task OnGetAsync()
        {
            Room = await _context.Room.ToListAsync();
        }
    }
}
