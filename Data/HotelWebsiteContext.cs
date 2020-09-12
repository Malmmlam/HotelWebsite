using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelWebsite.Models;

namespace HotelWebsite.Data
{
    public class HotelWebsiteContext : DbContext
    {
        public HotelWebsiteContext (DbContextOptions<HotelWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<HotelWebsite.Models.Room> Room { get; set; }
    }
}
