using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DataBaseTollPlaza.EF;
using System.Linq;

namespace SystemFramework
{
    public class SystemHelp
    {
        private static string EncryptionKey = "TollStation";
        public static string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static bool CheckExitForm(string _frmName, Form _frmMain)
        {
            // Design phai doi ten form khac text form
            bool check = false;
            foreach (Form frm in _frmMain.MdiChildren)
            {
                if (frm.Name == _frmName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static void ActiveChildForm(string _frmName, Form _frmMain)
        {
            foreach (Form frm in _frmMain.MdiChildren)
            {
                if (frm.Name == _frmName)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        public static void ShowChildForm(Form _frm, Form _frmMain)
        {
            _frm.MdiParent = _frmMain;
            _frm.Show();
        }
        public static void ClosedAllChild(Form _frmMain)
        {
            foreach (Form f in _frmMain.MdiChildren)
            {
                f.Close();
            }
        }
        public static int CheckInputSerie(string _sSerie, string _eSerie, string _ticketSerie, 
            string _ticketType, int _startSerie, int _endSerie ) {
            int rs = 0;
            try
            {
                if (_sSerie.Length != 17 || _eSerie.Length != 17)
                {
                    rs = 1;
                }
                else if (_ticketType != _eSerie.Substring(8, 1))
                {
                    rs = 2;
                }
                else if (_startSerie > _endSerie)
                {
                    rs = 3;
                }
                else if (_ticketSerie != _eSerie.Substring(0, 10))
                {
                    rs = 4;
                }
            }
            catch (Exception ex) {
                Console.Write("" + ex);                
            }
            return rs;
        }
        public static string Format_TicketSerie(string _fStr, string _lStr, string _fStr1, string _lStr1)
        {
            string rs = "0000000";
            string rt = "";
            rt = _fStr + rs.Substring(0, (rs.Length - _lStr.ToString().Length))+ _lStr + " => ";

            string rs2 = "0000000";
            rt += _fStr1 + rs2.Substring(0, (rs2.Length - _lStr1.ToString().Length)) +_lStr1 + ";";

            return rt;
        }
        public static center_ticket_type GetTicketTypeFromList(string ticketSerie, List<center_ticket_type> _lstTicketType)
        {
            center_ticket_type rs = null;
            try
            {
                byte _classify_type = (byte)Int32.Parse(ticketSerie.Substring(9, 1));
                byte _ticket_type = (byte)Int32.Parse(ticketSerie.Substring(8, 1));
                return (from a in _lstTicketType
                        where a.ticket_type == _ticket_type && a.classify_type == _classify_type
                        select a).Single();
            }
            catch (Exception)
            {
                rs = null;
            }
            return rs;
        }

    }
}
