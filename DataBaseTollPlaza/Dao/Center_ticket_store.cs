using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTollPlaza.Dao
{
    public class Center_ticket_store
    {
        TS_CENTEREntities db = null;
        public Center_ticket_store()
        {
            db = new TS_CENTEREntities();
        }

        public int CountTicket() {
            try
            {
                int _count = db.center_ticket_store.Count();
                return _count;
            }
            catch (Exception ex) {
                Console.Write("" + ex);
                return 0;
            }
        }
        public IEnumerable<center_ticket_store> GetAllTicketStore() {
            yield return (from a in db.center_ticket_store orderby a.ticket_type ascending select a).FirstOrDefault();
        }
        public List<center_ticket_store> GetListTicketStore()
        {
            try
            {
                List<center_ticket_store> lst = (from c in db.center_ticket_store
                                                 orderby c.ticket_type descending
                                                select c).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<center_ticket_store> GetByPage(int pageSize, int pageNum) {            
            try
            {
                var temp = (from a in db.center_ticket_store orderby a.ticket_type ascending select a).ToList();
                var list = temp.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
                return list;
            }
            catch (Exception ex) {
                Console.Write("" + ex);
                return null;
            }            
        }
        public List<center_ticket_store> Find(string startSerie, string endSerie, int pageSize, int pageNum)
        {
            try
            {
                var temp = (from a in db.center_ticket_store
                            orderby a.ticket_type ascending select a).ToList();
                var list = temp.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write("" + ex);
                return null;
            }
        }
        public bool Add(center_ticket_store ticket_store)
        {
            bool rs = false;
            try
            {
                db.center_ticket_store.Add(ticket_store);
                db.SaveChanges();
                rs = true;
            }
            catch (Exception)
            {
                rs = false;
            }

            return rs;
        }

    }
}
