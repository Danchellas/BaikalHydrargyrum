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
        public void Create(Marker marker)
        {
            Markers.Add(marker);
            SaveChanges();
        }

        public Marker Read(int id)
        {
            return Markers.FirstOrDefault(e => e.ID == id);
        }

        public void Update(Marker marker)
        {
            Markers.Update(marker);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var marker = Read(id);
            if (marker != null)
            {
                Markers.Remove(marker);
                SaveChanges();
            }
        }
    }

}

