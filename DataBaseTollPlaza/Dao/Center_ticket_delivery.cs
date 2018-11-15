using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTollPlaza.Dao
{
    public class Center_ticket_delivery
    {
        TS_CENTEREntities db = null;
        public Center_ticket_delivery()
        {
            db = new TS_CENTEREntities();
        }
        public int CountTicket()
        {
            try
            {
                int _count = db.center_ticket_delivery.Count();
                return _count;
            }
            catch (Exception ex)
            {
                Console.Write("" + ex);
                return 0;
            }
        }
        public List<center_ticket_delivery> GetAll()
        {
            try
            {
                List<center_ticket_delivery> lst = (from c in db.center_ticket_delivery
                                                 orderby c.ticket_type descending
                                                 select c).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Add(center_ticket_delivery ticket_delivery)
        {
            try
            {
                db.center_ticket_delivery.Add(ticket_delivery);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
