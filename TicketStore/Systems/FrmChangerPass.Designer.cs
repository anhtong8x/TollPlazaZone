namespace TicketStore.Systems
{
    partial class FrmChangerPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtPassConfirm);
            this.groupBox1.Controls.Add(this.txtPassNew);
            this.groupBox1.Controls.Add(this.txtPassOld);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(135, 26);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.PasswordChar = 'x';
            this.txtPassOld.Size = new System.Drawing.Size(178, 20);
            this.txtPassOld.TabIndex = 1;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(135, 57);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = 'x';
            this.txtPassNew.Size = new System.Drawing.Size(178, 20);
            this.txtPassNew.TabIndex = 2;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(135, 90);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = 'x';
            this.txtPassConfirm.Size = new System.Drawing.Size(178, 20);
            this.txtPassConfirm.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 130);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(7, 161);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(54, 16);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "lblMsg";
            // 
            // FrmChangerPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 404);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChangerPass";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmChangerPass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblMsg;
    }
}