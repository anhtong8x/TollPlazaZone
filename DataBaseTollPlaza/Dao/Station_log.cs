using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTollPlaza.Dao
{
    public class Station_log
    {
        TS_CENTEREntities db = null;
        public Station_log()
        {
            db = new TS_CENTEREntities();
        }

        public bool Insert(station_log _station_log) {
            try
            {
                db.station_log.Add(_station_log);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
            }            
        }

    }
}
