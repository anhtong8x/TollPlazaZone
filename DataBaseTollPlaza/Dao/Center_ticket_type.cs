using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTollPlaza.Dao
{
    public class Center_ticket_type
    {
        TS_CENTEREntities db = null;
        public Center_ticket_type()
        {
            db = new TS_CENTEREntities();
        }
        public List<center_ticket_type> GetListTicketType()
        {
            try
            {
                List<center_ticket_type> lst = (from c in db.center_ticket_type
                                                orderby c.id ascending
                                                select c).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<center_ticket_type> GetListPayment() {
            try
            {
                return (from a in db.center_ticket_type where a.ticket_type == 1 orderby a.id select a).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<center_ticket_type> GetAllTicketType() {
            yield return (from c in db.center_ticket_type orderby c.id descending select c).FirstOrDefault();
        }

    }
}
