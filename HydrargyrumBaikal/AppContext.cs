using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HydrargyrumBaikal
{
     class AppContext : DbContext
    {

        public DbSet<Point> Markers { get; set; }

        public AppContext() : base("DefaultConnetion") { }

    }
}
