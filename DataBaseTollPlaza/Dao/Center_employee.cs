using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using SystemFramework;

namespace DataBaseTollPlaza.Dao
{
    public class Center_employee
    {
        TS_CENTEREntities db = null;
        public Center_employee()
        {
            db = new TS_CENTEREntities();
        }
        public bool UserLogin(string _uName, string _pWord)
        {
            try
            {
                var sl = db.center_employee.Count(x => x.uname == _uName && x.password == _pWord);
                if (sl > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        /// <summary>
        /// 0 -> login false
        /// 1 -> access denied permissions
        /// 2 -> stop access
        /// 3 -> login success
        /// </summary>
        /// <param name="_uName"></param>
        /// <param name="_pWord"></param>
        /// <returns></returns>
        public int UserIsLogin(string _uName, string _pWord)
        {
            int rs = 0;
            try
            {
                var item = db.center_employee.FirstOrDefault(x => x.uname == _uName && x.password == _pWord);
                if (item == null)
                {
                    rs = 0;
                }
                else if (item.isAccountant == false)
                {
                    rs = 1;
                }
                else if (item.status == false) {
                    rs = 2;
                }
                else {
                    rs = 3;

                    Station_log station_Log = new Station_log();
                    station_Log.Insert(new station_log() {
                        created_date = DateTime.Now,
                        created_user = (short)item.id,
                        log_type = (byte)LogType.GENERAL,
                        action = (byte)LogAction.LOGIN,
                        log_name = string.Format(SystemMessage.Login,item.displayname,SystemMessage.TicketStore,DateTime.Now.ToString(SystemMessage.fmDate)),
                        description = SystemMessage.LogLoginSuccess
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                rs= 0;
            }
            return rs;
        }
        public center_employee GetByUserName(string _uName)
        {
            return db.center_employee.FirstOrDefault(x => x.uname == _uName);
        }
        public bool Update(center_employee _center_employee) {
            bool rs = false;
            try
            {
                var item = db.center_employee.FirstOrDefault(x => x.uname == _center_employee.uname && x.password == _center_employee.password);
                if (item == null)
                {
                    rs = false;
                }
                else {
                    item.password = _center_employee.password;
                    db.SaveChanges();
                    rs = true;

                    Station_log station_Log = new Station_log();
                    station_Log.Insert(new station_log()
                    {
                        created_date = DateTime.Now,
                        created_user = (short)item.id,
                        log_type = (byte)LogType.GENERAL,
                        action = (byte)LogAction.UPDATE,
                        log_name = string.Format(SystemMessage.Login, item.displayname, SystemMessage.TicketStore, DateTime.Now.ToString(SystemMessage.fmDate)),
                        description = SystemMessage.LogUpdateSuccess
                    });

                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                rs = false;
            }
            return rs;
        }
        public List<center_employee> GetAll() {
            try
            {
                List<center_employee> lst = (from c in db.center_employee
                                                orderby c.id ascending
                                                select c).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<center_employee> GetIsCabin()
        {
            try
            {
                List<center_employee> lst = (from c in db.center_employee
                                             where c.isCabin == true
                                             orderby c.displayname ascending
                                             select c).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
