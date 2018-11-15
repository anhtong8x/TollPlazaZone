namespace TicketStore.TicketStores
{
    partial class Frm_DeliveryTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.txtSerieEnd = new System.Windows.Forms.TextBox();
            this.txtSerieStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnFindTicket = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.Col_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEmployee);
            this.groupBox1.Controls.Add(this.txtSerieEnd);
            this.groupBox1.Controls.Add(this.txtSerieStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giao vé";
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(97, 21);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(302, 21);
            this.cboEmployee.TabIndex = 1;
            // 
            // txtSerieEnd
            // 
            this.txtSerieEnd.Location = new System.Drawing.Point(537, 60);
            this.txtSerieEnd.Name = "txtSerieEnd";
            this.txtSerieEnd.Size = new System.Drawing.Size(280, 20);
            this.txtSerieEnd.TabIndex = 3;
            this.txtSerieEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerieEnd_KeyUp);
            // 
            // txtSerieStart
            // 
            this.txtSerieStart.Location = new System.Drawing.Point(97, 60);
            this.txtSerieStart.Name = "txtSerieStart";
            this.txtSerieStart.Size = new System.Drawing.Size(302, 20);
            this.txtSerieStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số serie kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số serie bắt đâu";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(770, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
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
            this.lblMsg.Location = new System.Drawing.Point(337, 126);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(54, 16);
            this.lblMsg.TabIndex = 15;
            this.lblMsg.Text = "lblMsg";
            // 
            // btnFindTicket
            // 
            this.btnFindTicket.Location = new System.Drawing.Point(255, 119);
            this.btnFindTicket.Name = "btnFindTicket";
            this.btnFindTicket.Size = new System.Drawing.Size(75, 23);
            this.btnFindTicket.TabIndex = 9;
            this.btnFindTicket.Text = "Tìm tất cả";
            this.btnFindTicket.UseVisualStyleBackColor = true;
            this.btnFindTicket.Click += new System.EventHandler(this.btnFindTicket_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(174, 119);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu vé";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 119);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Nhập mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 310);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vé trong kho";
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_0,
            this.Col_1,
            this.Col_2,
            this.Col_3,
            this.Col_4,
            this.Col_5,
            this.Col_6,
            this.Col_7,
            this.Col_8,
            this.Col_9,
            this.Col_11,
            this.Col12,
            this.Col_13});
            this.dtGrid.Location = new System.Drawing.Point(9, 19);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersVisible = false;
            this.dtGrid.Size = new System.Drawing.Size(818, 279);
            this.dtGrid.TabIndex = 0;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(734, 469);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(24, 13);
            this.lblPageInfo.TabIndex = 19;
            this.lblPageInfo.Text = "0/0";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(807, 464);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(770, 464);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(31, 23);
            this.btnPre.TabIndex = 18;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // Col_0
            // 
            this.Col_0.HeaderText = "TT";
            this.Col_0.Name = "Col_0";
            this.Col_0.Width = 50;
            // 
            // Col_1
            // 
            this.Col_1.HeaderText = "x";
            this.Col_1.Name = "Col_1";
            this.Col_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col_1.Visible = false;
            this.Col_1.Width = 20;
            // 
            // Col_2
            // 
            this.Col_2.HeaderText = "Tên loại vé";
            this.Col_2.Name = "Col_2";
            // 
            // Col_3
            // 
            this.Col_3.HeaderText = "Serie vé";
            this.Col_3.Name = "Col_3";
            // 
            // Col_4
            // 
            this.Col_4.HeaderText = "Serie đầu";
            this.Col_4.Name = "Col_4";
            // 
            // Col_5
            // 
            this.Col_5.HeaderText = "Serie cuối";
            this.Col_5.Name = "Col_5";
            // 
            // Col_6
            // 
            this.Col_6.HeaderText = "Số lượng";
            this.Col_6.Name = "Col_6";
            // 
            // Col_7
            // 
            this.Col_7.HeaderText = "Người giao";
            this.Col_7.Name = "Col_7";
            // 
            // Col_8
            // 
            this.Col_8.HeaderText = "Ngày giao";
            this.Col_8.Name = "Col_8";
            // 
            // Col_9
            // 
            this.Col_9.HeaderText = "Ticket_Type";
            this.Col_9.Name = "Col_9";
            this.Col_9.Visible = false;
            // 
            // Col_11
            // 
            this.Col_11.HeaderText = "Deliveryer_Id";
            this.Col_11.Name = "Col_11";
            this.Col_11.Visible = false;
            // 
            // Col12
            // 
            this.Col12.HeaderText = "Receiver_Name";
            this.Col12.Name = "Col12";
            this.Col12.Visible = false;
            // 
            // Col_13
            // 
            this.Col_13.HeaderText = "Receiver_Id";
            this.Col_13.Name = "Col_13";
            this.Col_13.Visible = false;
            // 
            // Frm_DeliveryTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 494);
            this.Controls.Add(this.lblPageInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnFindTicket);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_DeliveryTicket";
            this.Text = "Giao vé lượt";
            this.Load += new System.EventHandler(this.Frm_DeliveryTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.TextBox txtSerieEnd;
        private System.Windows.Forms.TextBox txtSerieStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnFindTicket;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_0;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_13;
    }
}