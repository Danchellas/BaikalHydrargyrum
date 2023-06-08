using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydrargyrumBaikal
{
    internal class DBAdd
    {
            public void AddPoint(Marker marker)
            {
                using (var db = new AppContext())
                {
                    db.Markers.Add(marker);
                    db.SaveChanges();
                }
            }
        }
    }

