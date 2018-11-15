using DataBaseTollPlaza.Dao;
using DataBaseTollPlaza.EF;
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
    public partial class FrmChangerPass : Form
    {
        public FrmChangerPass()
        {
            InitializeComponent();
        }

        public center_employee _employee;
        private void FrmChangerPass_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            txtPassOld.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldPass = txtPassOld.Text.Trim();
            string newPass = txtPassNew.Text.Trim();
            string confirmPass = txtPassConfirm.Text.Trim();

            #region "checkInput"
            if (oldPass == "")
            {
                lblMsg.Text = SystemMessage.WarningPassword;
                txtPassOld.Focus();
                return;
            }

            if (newPass == "")
            {
                lblMsg.Text = SystemMessage.WarningPassword;
                txtPassNew.Focus();
                return;
            }

            if (newPass != confirmPass)
            {
                lblMsg.Text = SystemMessage.WarningConfirmPassword;
                txtPassConfirm.Focus();
                return;
            }

            oldPass = SystemHelp.Encrypt(oldPass);
            if (oldPass != _employee.password) {
                lblMsg.Text = SystemMessage.WarningOldPassword;
                return;
            }
            #endregion

            #region "update"
            _employee.password = oldPass;
            var employee_ = new Center_employee();
            if (employee_.Update(_employee)) {
                lblMsg.Text = SystemMessage.LogUpdateSuccess;
                txtPassOld.Text = "";
                txtPassNew.Text = "";
                txtPassConfirm.Text = "";
            }
            else
            {
                lblMsg.Text = SystemMessage.ErrorChangerPassword;                
            }
            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
