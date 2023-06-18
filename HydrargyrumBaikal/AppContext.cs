using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;


namespace HydrargyrumBaikal
{
     class AppContext : DbContext
    {

        public DbSet<Marker> Markers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hgdb.db");
        }
          
    }

}

