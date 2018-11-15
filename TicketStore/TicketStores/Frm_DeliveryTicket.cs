using DataBaseTollPlaza.Dao;
using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SystemFramework;

namespace TicketStore.TicketStores
{
    public partial class Frm_DeliveryTicket : Form
    {
        public Frm_DeliveryTicket()
        {
            InitializeComponent();
        }

        #region "logic"
        /*
        - _flag = 0 dang lam viec gi tren form. Mac dinh la 0. _flag = -1 cac bang lien ket chua co du lieu
        - load all employee ke toan, ban ve vao list
        - load all ticket_type vao list
        - load all ticket_delivery vao list. showdata phan trang
        - Dua list nhan vien chi ban ve vao cboEmployee. Note ptu 0 -> chon nhan vien        
        - Key up txtEndSerie, if _flag = 1 then inpu for button Them else input for button find once.        
            + chek ticket input
            + check cbonEmployee != -1
            + check ticket input exit in grid
            + check ticket input exit in table
            + create obj ticket
            * if _flag = 1
                + add obj ticket to grid
              else 
                + call find
         - them: _fla = 1, huy them _flag = 0. nho xoa text
         - luu: _flag = 1 luu all grid. chu y khong xoa grid. doi _flag = 0 neu luu thanh cong
         - in : _flag = 0 in trong grid
        */
        #endregion

        #region "variable"
        public center_employee ObjLogin { get; set; }
        int _flag = 0;
        int _pageNum = 1;
        int _pageSize = 10;
        int _pageTotal = 0;

        List<center_ticket_type> _lstTicketType;
        List<center_ticket_delivery> _lstTicketDelivery;
        List<center_employee> _lstEmployee;

        #endregion

        #region "common"
        private List<center_employee> GetListIsCabin(List<center_employee> lstEmployee)
        {
            try
            {
                return (from a in lstEmployee where a.isCabin == true orderby a.displayname select a).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void SetDataSourceComboEmployee(List<center_employee> lst)
        {
            var item = new center_employee() { id = -1, displayname = "Người nhận vé" };
            List<center_employee> _data = new List<center_employee>();
            _data.Add(item);
            foreach (center_employee i in lst)
            {
                item = new center_employee() { id = i.id, displayname = i.displayname };
                _data.Add(item);
            }
            cboEmployee.DataSource = _data;
            cboEmployee.DisplayMember = "displayname";
            cboEmployee.ValueMember = "id";
        }
        private List<center_ticket_delivery> GetPage(List<center_ticket_delivery> _lstAll, int pageNum, int pageSize)
        {
            try
            {
                var temp = (from a in _lstAll orderby a.ticket_type ascending select a).ToList();
                var lst = temp.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void FillData(List<center_ticket_delivery> lst, int pageNum, int pageSize, int pageTotal)
        {
            dtGrid.Rows.Clear();

            #region "format_grid"
            int wdtg = dtGrid.Width;
            dtGrid.Columns[0].Width = (wdtg * 5) / 100;
            dtGrid.Columns[2].Width = (wdtg * 30) / 100;
            dtGrid.Columns[3].Width = (wdtg * 10) / 100;
            dtGrid.Columns[4].Width = (wdtg * 10) / 100;
            dtGrid.Columns[5].Width = (wdtg * 10) / 100;
            dtGrid.Columns[6].Width = (wdtg * 10) / 100;
            dtGrid.Columns[7].Width = (wdtg * 15) / 100;
            dtGrid.Columns[8].Width = wdtg - (
                dtGrid.Columns[0].Width +
                dtGrid.Columns[2].Width +
                dtGrid.Columns[3].Width +
                dtGrid.Columns[4].Width +
                dtGrid.Columns[5].Width +
                dtGrid.Columns[6].Width +
                dtGrid.Columns[7].Width
                );

            #endregion

            #region "fill_data"
            int pos = 1 + (pageNum - 1) * pageSize;
            foreach (center_ticket_delivery item in lst)
            {
                DataGridViewRow row = (DataGridViewRow)dtGrid.RowTemplate.Clone();
                row.CreateCells(dtGrid,
                    pos,
                    false,
                    item.ticket_name,
                    item.ticketSerie,
                    item.startSerie,
                    item.endSerie,
                    item.quantity,
                    item.deliveryer_name,
                    item.delivery_date,
                    item.ticket_type);
                dtGrid.Rows.Add(row);
                pos++;
            }
            dtGrid.Columns[1].Visible = false;
            #endregion

            lblPageInfo.Text = pageNum + "/" + pageTotal;
        }
        private void AddRowToGrid(center_ticket_delivery item)
        {
            int pos = dtGrid.RowCount + 1;
            DataGridViewRow row = (DataGridViewRow)dtGrid.RowTemplate.Clone();
            row.CreateCells(dtGrid,
                pos,
                false,
                item.ticket_name,
                item.ticketSerie,
                item.startSerie,
                item.endSerie,
                item.quantity,
                item.deliveryer_name,
                item.delivery_date,
                item.ticket_type,
                item.deliveryer,
                item.receiver_name,
                item.receiver
                );
            dtGrid.Rows.Add(row);
        }
        private bool CheckTicketInGrid(center_ticket_delivery item)
        {
            bool isCheck = false;
            int _sNum, _eNum;
            string _ticketType = "";
            try
            {
                foreach (DataGridViewRow row in dtGrid.Rows)
                {
                    _ticketType = row.Cells[9].Value.ToString();

                    if(_ticketType == item.ticket_type)
                    {                        
                        _sNum = Int32.Parse(row.Cells[4].Value.ToString());
                        _eNum = Int32.Parse(row.Cells[5].Value.ToString());

                        if ((item.startSerie >= _sNum) && (item.endSerie <= _eNum))
                        {
                            isCheck = true;
                            break;
                        }

                        if (_sNum >= item.startSerie && _sNum <= item.endSerie)
                        {
                            isCheck = true;
                            break;
                        }
                        if (_eNum >= item.startSerie && _eNum <= item.endSerie)
                        {
                            isCheck = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                isCheck = false;
            }
            return isCheck;
        }      
        private center_ticket_delivery FindInListTable(center_ticket_delivery item, List<center_ticket_delivery> lst) {
            center_ticket_delivery rs = null;
            try
            {
                rs = (from a in lst
                      where a.ticket_type == item.ticket_type && item.startSerie >= a.startSerie && item.endSerie <= a.endSerie
                      select a).SingleOrDefault();
                return rs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region "event"

        #endregion
        private void Frm_DeliveryTicket_Load(object sender, EventArgs e)
        {
            try
            {
                #region "initLoad"
                lblMsg.Text = "";
                cboEmployee.Enabled = false;

                Center_ticket_type _iCenter_ticket_type = new Center_ticket_type();
                _lstTicketType = _iCenter_ticket_type.GetListPayment();
                if (_lstTicketType.Count <= 0)
                {
                    lblMsg.Text = SystemMessage.WarningTableTicketTypeNull;
                    _flag = -1;
                    return;
                }

                Center_employee _iCenter_employee = new Center_employee();
                _lstEmployee = _iCenter_employee.GetIsCabin();
                if (_lstEmployee.Count <= 0)
                {
                    lblMsg.Text = SystemMessage.WarningIsCabinNull;
                    _flag = -1;
                    return;
                }
                SetDataSourceComboEmployee(_lstEmployee);

                Center_ticket_delivery _iCenter_ticket_delivery = new Center_ticket_delivery();
                _lstTicketDelivery = _iCenter_ticket_delivery.GetAll();

                _pageTotal = _lstTicketDelivery.Count();
                if (_pageTotal <= 0) { return; }
                int p = _pageTotal / _pageSize;
                if (_pageTotal % _pageSize > 0)
                {
                    p++;
                }
                _pageTotal = p;
                FillData(GetPage(_lstTicketDelivery, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
                #endregion
            }
            catch (Exception)
            {
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (_flag == -1) return;
            try
            {
                if (_pageNum > 1 && _flag == 0)
                {
                    _pageNum--;
                    FillData(GetPage(_lstTicketDelivery, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_flag == -1) return;
            try
            {
                if (_pageNum < _pageTotal && _flag == 0)
                {
                    _pageNum++;
                    FillData(GetPage(_lstTicketDelivery, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtSerieEnd_KeyUp(object sender, KeyEventArgs e)
        {
            if (_flag == -1) return;
            try
            {
                #region "input"
                lblMsg.Text = "";
                string _serieStart = txtSerieStart.Text.Trim().ToUpper();
                string _serieEnd = txtSerieEnd.Text.Trim().ToUpper();
                if (_serieStart == "" || _serieEnd == "") { return; }

                string _ticketSerie = _serieStart.Substring(0, 10);
                string _ticketType = _serieStart.Substring(8, 1);
                int _sNum = Int32.Parse(_serieStart.Substring(10));
                int _eNum = Int32.Parse(_serieEnd.Substring(10));
                #endregion

                #region "check_inputSerie"
                int rs = SystemHelp.CheckInputSerie(_serieStart, _serieEnd, _ticketSerie, _ticketType, _sNum, _eNum);
                if (rs == 1)
                {
                    lblMsg.Text = SystemMessage.WarningStartNumberErr;
                    return;
                }
                else if (rs == 2)
                {
                    lblMsg.Text = SystemMessage.WarningTicketTypeErr;
                    return;
                }
                else if (rs == 3)
                {
                    lblMsg.Text = SystemMessage.WarningMinMaxErr;
                    return;
                }
                else if (rs == 4)
                {
                    lblMsg.Text = SystemMessage.WarningTicketTypeErr;
                    return;
                }

                #endregion

                #region "check_select_employee"
                if (cboEmployee.SelectedIndex == 0 && _flag == 1)
                {
                    lblMsg.Text = SystemMessage.WarningEmployeeNull;
                    txtSerieEnd.Text = "";
                    txtSerieStart.Text = "";
                    cboEmployee.Focus();
                    return;
                }
                #endregion               

                if (_flag == 0) { _flag = 2; }

                // get ticket_type
                var itemTicketType = SystemHelp.GetTicketTypeFromList(_ticketSerie, _lstTicketType);

                // create obj ticket_delivery
                center_ticket_delivery itemTicket_delivery = new center_ticket_delivery()
                {
                    delivery_date = DateTime.Now,
                    deliveryer_name = ObjLogin.displayname,
                    deliveryer = ObjLogin.id,
                    receiver_name = cboEmployee.Text,
                    receiver = Int32.Parse(cboEmployee.SelectedValue.ToString()),
                    ticket_name = itemTicketType.ticket_name,
                    ticket_type = itemTicketType.id,
                    quantity = _eNum - _sNum + 1,
                    startSerie = _sNum,
                    endSerie = _eNum,
                    ticketSerie = _ticketSerie,
                    session_id = 0
                };

                // nhap cua them moi
                if (_flag == 1)
                {                    
                    // check ticket_delivery in grid
                    if (CheckTicketInGrid(itemTicket_delivery))
                    {
                        lblMsg.Text = SystemMessage.WarningExitInputTicket;
                        return;
                    }

                    // check ticket_delivery in table
                    if (FindInListTable(itemTicket_delivery, _lstTicketDelivery) != null)
                    {
                        lblMsg.Text = SystemMessage.WarningSaveTicketDelivery;
                        return;
                    }

                    // add ticket to grid
                    AddRowToGrid(itemTicket_delivery);
                    cboEmployee.Enabled = false;
                    txtSerieStart.Text = "";
                    txtSerieEnd.Text = "";
                    txtSerieStart.Focus();
                }
                else if (_flag == 2){
                    // nhap cua tim serie ve
                    _flag = 0;
                    if (_pageTotal > 0)
                    {
                        dtGrid.Rows.Clear();
                        var item = FindInListTable(itemTicket_delivery, _lstTicketDelivery);                        
                        if (item == null) {
                            lblMsg.Text = "Không tim thấy vé.";
                            cboEmployee.SelectedIndex = 0;
                            lblPageInfo.Text = "";
                            return;
                        }                        
                        
                        DataGridViewRow row = (DataGridViewRow)dtGrid.RowTemplate.Clone();
                        row.CreateCells(dtGrid,
                            1,
                            false,
                            item.ticket_name,
                            item.ticketSerie,
                            item.startSerie,
                            item.endSerie,
                            item.quantity,
                            item.deliveryer_name,
                            item.delivery_date,
                            item.ticket_type);
                        dtGrid.Rows.Add(row);

                        cboEmployee.Text = item.receiver_name;
                        lblPageInfo.Text = "1/1";
                        btnPre.Enabled = false;
                        btnNext.Enabled = false;
                        
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (_flag == -1) return;
            if (_flag == 0)
            {
                // neu nhan them
                btnNew.Text = "Hủy Thêm";
                lblPageInfo.Text = "";
                _flag = 1;
                txtSerieStart.Text = "";
                txtSerieEnd.Text = "";
                lblMsg.Text = "";
                cboEmployee.Enabled = true;
                cboEmployee.SelectedIndex = 0;
                dtGrid.Rows.Clear();
            }
            else if (_flag == 1)
            {
                // neu nhan huy ma co du lieu o grid thi ? xac nhan 
                if (dtGrid.Rows.Count > 0)
                {
                    var rs = MessageBox.Show(SystemMessage.WarningSaveExit, SystemMessage.CaptionConfirmMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        btnNew.Text = "Thêm mới";
                        _flag = 0;
                        txtSerieStart.Text = "";
                        txtSerieEnd.Text = "";
                        lblMsg.Text = "";
                        cboEmployee.SelectedIndex = 0;
                        cboEmployee.Enabled = false;
                        FillData(GetPage(_lstTicketDelivery, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
                    }
                }
                else
                {
                    btnNew.Text = "Thêm mới";
                    _flag = 0;
                    txtSerieStart.Text = "";
                    txtSerieEnd.Text = "";
                    lblMsg.Text = "";
                    cboEmployee.Enabled = false;
                    cboEmployee.SelectedIndex = 0;
                    FillData(GetPage(_lstTicketDelivery, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_flag == -1) return;
            try
            {
                if (_flag == 1 && dtGrid.Rows.Count > 0)
                {
                    var _iCenter_ticket_store = new Center_ticket_delivery();

                    center_ticket_delivery _center_ticket_delivery;
                    int _sNum, _eNum;
                    foreach (DataGridViewRow row in dtGrid.Rows)
                    {
                        _sNum = Int32.Parse(row.Cells[4].Value.ToString());
                        _eNum = Int32.Parse(row.Cells[5].Value.ToString());

                        _center_ticket_delivery = new center_ticket_delivery()
                        {
                            ticket_name = row.Cells[2].Value.ToString(),
                            ticketSerie = row.Cells[3].Value.ToString(),
                            startSerie = _sNum,
                            endSerie =_eNum,
                            quantity = _eNum - _sNum + 1,
                            deliveryer_name = row.Cells[7].Value.ToString(),
                            delivery_date = DateTime.Now,
                            ticket_type = row.Cells[9].Value.ToString(),                
                            deliveryer = Int32.Parse(row.Cells[10].Value.ToString()),
                            receiver_name = row.Cells[11].Value.ToString(),
                            receiver = Int32.Parse(row.Cells[12].Value.ToString())
                        };
                        if (_iCenter_ticket_store.Add(_center_ticket_delivery))
                        {
                            lblMsg.Text = SystemMessage.WarningSaveSuccess;
                            _lstTicketDelivery.Add(_center_ticket_delivery);
                        }
                        else
                        {
                            lblMsg.Text = "Lỗi khi đang lưu dữ liệu";
                            break;
                        }
                    }

                    // khi luu xong
                    _flag = 0;
                    btnNew.Text = "Thêm mới";
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_flag == -1) return;
            if(_flag == 0)
            {
                MessageBox.Show("print");
            }
        }

        private void btnFindTicket_Click(object sender, EventArgs e)
        {
            if (_flag == -1) return;
            if(_flag == 0)
            {
                txtSerieStart.Text = "";
                txtSerieEnd.Text = "";
                lblMsg.Text = "";
                btnNext.Enabled = true;
                btnPre.Enabled = true;
                cboEmployee.SelectedIndex = 0;
                FillData(GetPage(_lstTicketDelivery, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_flag != 0 && dtGrid.Rows.Count > 0)
            {
                var rs = MessageBox.Show(SystemMessage.WarningSaveExit,
                SystemMessage.CaptionConfirmMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

    }
}
