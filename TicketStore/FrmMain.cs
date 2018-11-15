using DataBaseTollPlaza.Dao;
using DataBaseTollPlaza.EF;
using System;
using System.Windows.Forms;
using SystemFramework;
using TicketStore.Systems;
using TicketStore.TicketStores;

namespace TicketStore
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region "variable"
        private string _userName;
        private center_employee _employee;
        public void GetUserNameLogin(string _uName) { _userName = _uName; } // delegate in FrmLogin
        #endregion

        #region "event"
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin._getUserName = new FrmLogin.GetUserName(GetUserNameLogin);
                if (frmLogin.ShowDialog(this) == DialogResult.OK)
                {
                    Center_employee center_Employee = new Center_employee();
                    _employee = center_Employee.GetByUserName(_userName);

                    this.Show();
                    toolStripStatusLabel1.Text = string.Format(SystemMessage.StatusInfo, _employee.displayname);
                }
                else
                {
                    SystemHelp.ClosedAllChild(this);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex + "");
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var rs = MessageBox.Show(SystemMessage.WarningExitAppication,
                SystemMessage.CaptionConfirmMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                SystemHelp.ClosedAllChild(this);
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }



        #endregion

        #region "system"
        private void item_ChangerPass_Click(object sender, EventArgs e)
        {
            // Nho khong de Name va text form giong nhau
            if (!SystemHelp.CheckExitForm("FrmChangerPass", this))
            {
                FrmChangerPass frm = new FrmChangerPass();
                frm._employee = _employee;
                SystemHelp.ShowChildForm(frm, this);
            }
            else
            {
                SystemHelp.ActiveChildForm("FrmChangerPass", this);
            }
        }
        private void item_ExitApp_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs formClosingEventArgs = new FormClosingEventArgs(CloseReason.MdiFormClosing, false);
            FrmMain_FormClosing(null, formClosingEventArgs);
        }        

        #endregion

        #region "category"

        #endregion

        #region "ticketStore"
        private void item_InputTicket_Click(object sender, EventArgs e)
        {            
            if (!SystemHelp.CheckExitForm("Frm_InputTicket", this ))
            {
                Frm_InputTicket frm = new Frm_InputTicket();
                SystemHelp.ShowChildForm(frm, this);
            }
            else
            {
                SystemHelp.ActiveChildForm("Frm_InputTicket", this);
            }
        }
        private void item_DeliveryTicket_Click(object sender, EventArgs e)
        {
            if (!SystemHelp.CheckExitForm("Frm_DeliveryTicket", this))
            {
                Frm_DeliveryTicket frm = new Frm_DeliveryTicket();
                frm.ObjLogin = _employee;
                SystemHelp.ShowChildForm(frm, this);
            }
            else
            {
                SystemHelp.ActiveChildForm("Frm_DeliveryTicket", this);
            }
        }



        #endregion

        
    }
}
