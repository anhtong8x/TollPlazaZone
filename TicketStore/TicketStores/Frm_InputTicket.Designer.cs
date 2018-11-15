namespace TicketStore.TicketStores
{
    partial class Frm_InputTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSerieEnd = new System.Windows.Forms.TextBox();
            this.txtSerieStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.Col_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TicketName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SerieStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SerieEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DateInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TicketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnFindTicket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSerieEnd);
            this.groupBox1.Controls.Add(this.txtSerieStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vé nhập";
            // 
            // txtSerieEnd
            // 
            this.txtSerieEnd.Location = new System.Drawing.Point(492, 32);
            this.txtSerieEnd.Name = "txtSerieEnd";
            this.txtSerieEnd.Size = new System.Drawing.Size(265, 20);
            this.txtSerieEnd.TabIndex = 2;
            this.txtSerieEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerieEnd_KeyUp);
            // 
            // txtSerieStart
            // 
            this.txtSerieStart.Location = new System.Drawing.Point(97, 32);
            this.txtSerieStart.Name = "txtSerieStart";
            this.txtSerieStart.Size = new System.Drawing.Size(265, 20);
            this.txtSerieStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số serie kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số serie bắt đâu";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 89);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Nhập mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu vé";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(174, 89);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(337, 96);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(54, 16);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "lblMsg";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(700, 89);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 332);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vé trong kho";
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Index,
            this.Col_TicketName,
            this.Col_Serie,
            this.Col_SerieStart,
            this.Col_SerieEnd,
            this.Col_Quanity,
            this.Col_BookNumber,
            this.Col_DateInput,
            this.Col_TicketType});
            this.dtGrid.Location = new System.Drawing.Point(9, 19);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.RowHeadersVisible = false;
            this.dtGrid.Size = new System.Drawing.Size(748, 307);
            this.dtGrid.TabIndex = 0;
            // 
            // Col_Index
            // 
            this.Col_Index.HeaderText = "STT";
            this.Col_Index.Name = "Col_Index";
            this.Col_Index.ReadOnly = true;
            // 
            // Col_TicketName
            // 
            this.Col_TicketName.HeaderText = "Tên loại vé";
            this.Col_TicketName.Name = "Col_TicketName";
            this.Col_TicketName.ReadOnly = true;
            // 
            // Col_Serie
            // 
            this.Col_Serie.HeaderText = "Serie vé";
            this.Col_Serie.Name = "Col_Serie";
            this.Col_Serie.ReadOnly = true;
            // 
            // Col_SerieStart
            // 
            this.Col_SerieStart.HeaderText = "Serie đầu";
            this.Col_SerieStart.Name = "Col_SerieStart";
            this.Col_SerieStart.ReadOnly = true;
            // 
            // Col_SerieEnd
            // 
            this.Col_SerieEnd.HeaderText = "Serie cuối";
            this.Col_SerieEnd.Name = "Col_SerieEnd";
            this.Col_SerieEnd.ReadOnly = true;
            // 
            // Col_Quanity
            // 
            this.Col_Quanity.HeaderText = "Số lượng";
            this.Col_Quanity.Name = "Col_Quanity";
            this.Col_Quanity.ReadOnly = true;
            // 
            // Col_BookNumber
            // 
            this.Col_BookNumber.HeaderText = "Số cọc";
            this.Col_BookNumber.Name = "Col_BookNumber";
            this.Col_BookNumber.ReadOnly = true;
            // 
            // Col_DateInput
            // 
            this.Col_DateInput.HeaderText = "Ngày nhập";
            this.Col_DateInput.Name = "Col_DateInput";
            this.Col_DateInput.ReadOnly = true;
            // 
            // Col_TicketType
            // 
            this.Col_TicketType.HeaderText = "TicketType";
            this.Col_TicketType.Name = "Col_TicketType";
            this.Col_TicketType.ReadOnly = true;
            this.Col_TicketType.Visible = false;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(706, 456);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(31, 23);
            this.btnPre.TabIndex = 10;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(743, 456);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(670, 461);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(24, 13);
            this.lblPageInfo.TabIndex = 11;
            this.lblPageInfo.Text = "0/0";
            // 
            // btnFindTicket
            // 
            this.btnFindTicket.Location = new System.Drawing.Point(255, 89);
            this.btnFindTicket.Name = "btnFindTicket";
            this.btnFindTicket.Size = new System.Drawing.Size(75, 23);
            this.btnFindTicket.TabIndex = 5;
            this.btnFindTicket.Text = "Tìm vé";
            this.btnFindTicket.UseVisualStyleBackColor = true;
            this.btnFindTicket.Click += new System.EventHandler(this.btnFindTicket_Click);
            // 
            // Frm_InputTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 491);
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
            this.Name = "Frm_InputTicket";
            this.Text = "Nhập vé vào kho";
            this.Load += new System.EventHandler(this.Frm_InputTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSerieStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.TextBox txtSerieEnd;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnFindTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TicketName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SerieStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SerieEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Quanity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DateInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TicketType;
    }
}