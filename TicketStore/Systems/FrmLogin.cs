using DataBaseTollPlaza.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemFramework;

namespace TicketStore.Systems
{
    public partial class FrmLogin : Form
    {
        public delegate void GetUserName(string _uName);
        public GetUserName _getUserName;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            txtUserName.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uName = txtUserName.Text.Trim();
            string pWord = txtPassWord.Text.Trim();

            #region "CheckInput"
            if (uName == "")
            {
                txtUserName.Focus();
                lblMsg.Text = SystemMessage.WarningUsername;
                return;
            }

            if (pWord == "")
            {
                txtPassWord.Focus();
                lblMsg.Text = SystemMessage.WarningPassword;
                return;
            }
            #endregion

            #region "Login"
            try
            {
                pWord = SystemHelp.Encrypt(pWord);
                var dao = new Center_employee();
                int rs = dao.UserIsLogin(uName, pWord);
                if (rs == 0)
                {
                    lblMsg.Text = SystemMessage.WarningErrorUsername;
                    return;
                }
                else if (rs == 1)
                {
                    lblMsg.Text = SystemMessage.WarningAccess;
                    return;
                }
                else if (rs == 2)
                {
                    lblMsg.Text = SystemMessage.WarningStatus;
                    return;
                }
                else {                    
                    _getUserName(uName);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                lblMsg.Text = SystemMessage.WarningConnection;
            }
            #endregion
        }
    }
}
