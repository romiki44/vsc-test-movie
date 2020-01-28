using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebRazor1.Models;

namespace WebRazor1.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
            this.Database.SetCommandTimeout(new TimeSpan(0, 1, 0));
        }

        public DbSet<WebRazor1.Models.Movie> Movie { get; set; }
    }
}
