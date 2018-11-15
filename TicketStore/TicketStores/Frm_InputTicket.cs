using DataBaseTollPlaza.Dao;
using DataBaseTollPlaza.EF;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemFramework;
using System.Linq;
using DevExpress.XtraSplashScreen;
using TicketStore.Reports;

namespace TicketStore.TicketStores
{
    public partial class Frm_InputTicket : Form
    {
        public Frm_InputTicket()
        {
            InitializeComponent();
        }

        #region "variable"
        List<center_ticket_store> _lstTicketStore;
        List<center_ticket_type> _lstTicketType;

        /// <summary>
        /// -1 -> chua nhap du lieu bang ticket_type 
        /// 0 -> default. Tim toan bo ve         
        /// 1 -> nhan them moi       
        /// 2 -> nhap du lieu tim ve
        /// </summary>
        int _flag = 0;
        int _pageNum = 1;    // so trang
        int _pageSize = 5;  // so row tren trang
        int _pageTotal = 0;


        #endregion

        #region "common
        private List<center_ticket_store> GetPage(List<center_ticket_store> lstAllTicket, int pageNum, int pageSize)
        {
            try
            {
                var temp = (from a in lstAllTicket orderby a.ticket_type ascending select a).ToList();
                var lst = temp.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
                return lst;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void FillData(List<center_ticket_store> lstTicket, int pageNum, int pageSize, int pageTotal)
        {
            dtGrid.Rows.Clear();

            #region "format_grid"
            int wdtg = dtGrid.Width;
            dtGrid.Columns[0].Width = (wdtg * 10) / 100;
            dtGrid.Columns[1].Width = (wdtg * 30) / 100;
            dtGrid.Columns[2].Width = (wdtg * 10) / 100;
            dtGrid.Columns[3].Width = (wdtg * 10) / 100;
            dtGrid.Columns[4].Width = (wdtg * 10) / 100;
            dtGrid.Columns[5].Width = (wdtg * 10) / 100;
            dtGrid.Columns[6].Width = (wdtg * 10) / 100;
            dtGrid.Columns[7].Width = wdtg - (
                dtGrid.Columns[0].Width +
                dtGrid.Columns[1].Width +
                dtGrid.Columns[2].Width +
                dtGrid.Columns[3].Width +
                dtGrid.Columns[4].Width +
                dtGrid.Columns[5].Width +
                dtGrid.Columns[6].Width
                );

            #endregion

            #region "fill_data"
            int pos = 1 + (pageNum - 1) * pageSize;
            foreach (center_ticket_store item in lstTicket)
            {
                DataGridViewRow row = (DataGridViewRow)dtGrid.RowTemplate.Clone();
                row.CreateCells(dtGrid,
                    pos,
                    item.ticket_name,
                    item.ticket_serie,
                    item.start_number_serie,
                    item.end_number_serie,
                    item.quantity,
                    item.book_number,
                    item.date_store,
                    item.ticket_type);
                dtGrid.Rows.Add(row);
                pos++;
            }
            dtGrid.Columns[8].Visible = false;
            #endregion

            lblPageInfo.Text = pageNum + "/" + pageTotal;
        }
        private List<center_ticket_store> FindTicketBySerie(List<center_ticket_store> lstAllTicket, string _ticketSerie, int _serieStart, int _serieEnd)
        {
            var temp = (from a in lstAllTicket
                        where (a.ticket_serie == _ticketSerie)
                        orderby a.ticket_serie descending
                        select a).ToList();
            return temp;
        }
        private bool CheckSerieInDataRow(center_ticket_store item)
        {
            bool isCheck = false;
            int _sNum, _eNum;
            try
            {
                foreach (DataGridViewRow row in dtGrid.Rows)
                {
                    if (item.ticket_serie == row.Cells[2].Value.ToString())
                    {
                        _sNum = Int32.Parse(row.Cells[3].Value.ToString());
                        _eNum = Int32.Parse(row.Cells[4].Value.ToString());

                        if ((item.start_number_serie >= _sNum) && (item.end_number_serie <= _eNum))
                        {
                            isCheck = true;
                            break;
                        }

                        if (_sNum >= item.start_number_serie && _sNum <= item.end_number_serie)
                        {
                            isCheck = true;
                            break;
                        }
                        if (_eNum >= item.start_number_serie && _eNum <= item.end_number_serie)
                        {
                            isCheck = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return isCheck;
        }
        private bool CheckSerieInTable(center_ticket_store item)
        {
            bool isCheck = false;
            try
            {
                var temp = (from a in _lstTicketStore
                            where (a.ticket_serie == item.ticket_serie)
                            orderby a.start_number_serie descending
                            select a).ToList();
                foreach (var j in temp)
                {
                    if (item.start_number_serie <= j.end_number_serie)
                    {
                        isCheck = true;
                        break;
                    }
                }

            }
            catch (Exception)
            {
            }
            return isCheck;
        }
        private void AddDataRow(center_ticket_store item)
        {
            #region "format_grid"
            int wdtg = dtGrid.Width;
            dtGrid.Columns[0].Width = (wdtg * 10) / 100;
            dtGrid.Columns[1].Width = (wdtg * 30) / 100;
            dtGrid.Columns[2].Width = (wdtg * 10) / 100;
            dtGrid.Columns[3].Width = (wdtg * 10) / 100;
            dtGrid.Columns[4].Width = (wdtg * 10) / 100;
            dtGrid.Columns[5].Width = (wdtg * 10) / 100;
            dtGrid.Columns[6].Width = (wdtg * 10) / 100;
            dtGrid.Columns[7].Width = wdtg - (
                dtGrid.Columns[0].Width +
                dtGrid.Columns[1].Width +
                dtGrid.Columns[2].Width +
                dtGrid.Columns[3].Width +
                dtGrid.Columns[4].Width +
                dtGrid.Columns[5].Width +
                dtGrid.Columns[6].Width
                );

            #endregion

            #region "add_newRow"
            int pos = dtGrid.RowCount + 1;
            DataGridViewRow row = (DataGridViewRow)dtGrid.RowTemplate.Clone();
            row.CreateCells(dtGrid,
                pos,
                item.ticket_name,
                item.ticket_serie,
                item.start_number_serie,
                item.end_number_serie,
                item.quantity,
                item.book_number,
                item.date_store,
                item.ticket_type);
            dtGrid.Rows.Add(row);

            #endregion
        }
        private center_ticket_type GetTicketId(string ticketSerie)
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

        #endregion

        #region "event"
        private void Frm_InputTicket_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = "";
                txtSerieStart.Focus();
                //SplashScreenManager.ShowForm(typeof(FrmSplash));

                #region "load_dataform"
                Center_ticket_type _iCenter_ticket_type = new Center_ticket_type();
                _lstTicketType = _iCenter_ticket_type.GetListTicketType();
                if (_lstTicketType == null)
                {
                    lblMsg.Text = SystemMessage.WarningTableTicketTypeNull;
                    _flag = -1; // chua nhap du lieu bang tickettype
                    return;
                }

                Center_ticket_store _iCenter_ticket_store = new Center_ticket_store();
                _lstTicketStore = _iCenter_ticket_store.GetListTicketStore();

                _pageTotal = _lstTicketStore.Count();
                if (_pageTotal <= 0) { return; }
                int p = _pageTotal / _pageSize;
                if (_pageTotal % _pageSize > 0)
                {
                    p++;
                }
                _pageTotal = p;
                FillData(GetPage(_lstTicketStore, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);

                #endregion

                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                Console.Write("" + ex);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_pageNum < _pageTotal && _flag == 0)
            {
                _pageNum++;
                FillData(GetPage(_lstTicketStore, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
            }
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (_pageNum > 1 && _flag == 0)
            {
                _pageNum--;
                FillData(GetPage(_lstTicketStore, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
            }
        }
        private void txtSerieEnd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lblMsg.Text = "";
                string _serieStart = txtSerieStart.Text.Trim().ToUpper();
                string _serieEnd = txtSerieEnd.Text.Trim().ToUpper();
                if (_serieStart == "" || _serieEnd == "") { return; }

                string _ticketSerie = _serieStart.Substring(0, 10);
                string _ticketType = _serieStart.Substring(8, 1);
                int _sNum = Int32.Parse(_serieStart.Substring(10));
                int _eNum = Int32.Parse(_serieEnd.Substring(10));

                #region "check_input"
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

                #region "create_dataRow"
                // neu nhat nut them thi flag = 1 va neu chua co trong grid thi dua du lieu vao grid
                // neu flag dang la 0 thi la tim kiem

                if (_flag == 0) { _flag = 2; } // dung co la dang tim ve

                if (_flag == 1)
                {
                    // neu nhap cua them moi
                    #region "get_infoticket"                  
                    center_ticket_type item = GetTicketId(_ticketSerie);
                    if (item == null) { lblMsg.Text = SystemMessage.WarningTableTicketTypeNull;  return; }
                    #endregion

                    #region "check_ticket_input"
                    var _tk = new center_ticket_store()
                    {
                        ticket_serie = _ticketSerie,
                        ticket_name = item.ticket_name,
                        ticket_type = item.id,
                        start_number_serie = _sNum,
                        end_number_serie = _eNum,
                        date_store = DateTime.Now,
                        date_out = DateTime.Now,
                        outForSale = false,
                        quantity = _eNum - _sNum + 1,
                        book_number = (_eNum - _sNum + 1) / 100,
                    };

                    // ktra da nhap vao grid chua
                    if (CheckSerieInDataRow(_tk))
                    {
                        lblMsg.Text = SystemMessage.WarningExitInputTicket;
                        return;
                    }
                    // ktra da nhap vao table chua
                    if (CheckSerieInTable(_tk))
                    {
                        lblMsg.Text = SystemMessage.WarningSaveTicket;
                        return;
                    }

                    #endregion

                    AddDataRow(_tk);

                    txtSerieStart.Text = "";
                    txtSerieEnd.Text = "";
                    txtSerieStart.Focus();
                }
                else if (_flag == 2)
                {
                    // neu nhap la tim kiem
                    if (_pageTotal > 0)
                    {
                        var lst = FindTicketBySerie(_lstTicketStore, _ticketSerie, _sNum, _eNum);
                        int p = 0;
                        if (lst.Count > 0) { p = 1; }
                        FillData(lst, p, 0, p);
                        _flag = 0;
                    }
                }
                #endregion

            }
            catch (Exception)
            {
            }
        }
        private void btnFindTicket_Click(object sender, EventArgs e)
        {
            if (_flag == 0)
            {
                _flag = 0;
                txtSerieStart.Text = "";
                txtSerieEnd.Text = "";
                lblMsg.Text = "";
                FillData(GetPage(_lstTicketStore, _pageNum, _pageSize), _pageNum, _pageSize, _pageTotal);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (_flag == 0)
            {
                // neu nhan them
                btnNew.Text = "Hủy";
                lblPageInfo.Text = "";
                _flag = 1;
                txtSerieStart.Text = "";
                txtSerieEnd.Text = "";
                lblMsg.Text = "";
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
                        btnFindTicket_Click(sender, e);
                    }
                }
                else
                {
                    btnNew.Text = "Thêm mới";
                    _flag = 0;
                    btnFindTicket_Click(sender, e);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // luu xong thi tra ve default. nho check grid count
                if (_flag == 1 && dtGrid.Rows.Count > 0)
                {
                    var _iCenter_ticket_store = new Center_ticket_store();
                    center_ticket_store _center_ticket_store;
                    int _sNum, _eNum;
                    foreach (DataGridViewRow row in dtGrid.Rows)
                    {
                        _sNum = Int32.Parse(row.Cells[3].Value.ToString());
                        _eNum = Int32.Parse(row.Cells[4].Value.ToString());

                        _center_ticket_store = new center_ticket_store()
                        {
                            ticket_serie = row.Cells[2].Value.ToString(),
                            ticket_name = row.Cells[1].Value.ToString(),
                            //ticket_type = GetTicketId(row.Cells[2].Value.ToString().Trim()).id,
                            ticket_type = row.Cells[8].Value.ToString(),
                            start_number_serie = _sNum,
                            end_number_serie = _eNum,
                            date_store = DateTime.Now,
                            date_out = DateTime.Now,
                            outForSale = false,
                            quantity = _eNum - _sNum + 1,
                            book_number = (_eNum - _sNum + 1) / 100
                        };
                        if (_iCenter_ticket_store.Add(_center_ticket_store))
                        {
                            lblMsg.Text = SystemMessage.WarningSaveSuccess;
                            _lstTicketStore.Add(_center_ticket_store);
                        }
                        else
                        {
                            break;
                        }
                    }

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
            try
            {
                // khong in khi nhan nhap moi
                if (_flag == 0 && dtGrid.Rows.Count > 0)
                {
                    #region "commentCreateReport"
                    /*
                     1. Report la du lieu trong dtgrid
                     2. dtgrid du lieu cua cac loai ve chua gop nho, vi vay can lap de dua vao nhom
                     3. Bao cao se gom nhom tung loai ve, tinh tong vao phan tu dau tien
                     3. Lap het cac loai ve trong bang ve
                     4. bien tam de tinh tong so ve cua nhom ve dang lap,
                     5. khi lay du lieu o row nao trong dtgrid thi danh dau lai. de khong lap row cua dtgrid nua neu da lay het roi
                     6. Moi lan lap row cuar grid ma tim thay se tao doi tuong row trong bao cao roi dua vao list data report
                     7. Danh dau lai vi tri phan tu dau tien trong moi nhom ve o list data report
                     8. Dem so nhom ve cho bao cao de lam stt 
                     */
                    #endregion

                    List<RptTicketStoreModel> _lstDataReport = new List<RptTicketStoreModel>();
                    #region "convert_dataGrid_to_Report"
                    int _sumQuantity = 0; // tong so luong nhom ve trong report
                    int _counRowData = 0; // so row trong grid da duoc lay du lieu vao report, de k lap lai neu da  het
                    int _sl = 0; // so ve trong tung row
                    RptTicketStoreModel _iRptTicketStoreModel; // 1 row trong list report
                    int _sttGroupTicket = 0; // so thu tu nhom ve trong report
                    int _indexItemRptDataReport = 0; // ptu dau tieng cua 1 nhom ve trong list datareport

                    // loop tung loai ve, so sanh voi tung row trong grid de tao du lieu cho report
                    foreach (center_ticket_type tkt in _lstTicketType) {

                        if (_counRowData > dtGrid.Rows.Count -1) { break; } // neu da lay het du lieu cac dong trong dtgrid thi k loop nua 

                        // vi tri nhom ve dau tien trong datareport. dung de tinh tong nhom ve
                        _indexItemRptDataReport = _lstDataReport.Count;

                        // loop tung row trong grid
                        foreach (DataGridViewRow row in dtGrid.Rows)
                        {
                            // neu tim thay ve thi dua vao list data report
                            if(tkt.id == row.Cells[8].Value.ToString())
                            {
                                _sl = Int32.Parse(row.Cells[5].Value.ToString());
                                _sumQuantity += _sl; // cong don tinh tong so ve theo loai
                                _iRptTicketStoreModel = new RptTicketStoreModel() {
                                    STT = -1,
                                    LOAIVE = "",
                                    DONGIA = -1,
                                    SOLUONGTONG = -1,
                                    SOLUONGSERIE = _sl,
                                    SOSERIE = SystemHelp.Format_TicketSerie(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(),
                                    row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString()),
                                    TTIEN = -1
                                };

                                _lstDataReport.Add(_iRptTicketStoreModel);
                                _counRowData++;
                            }
                        }

                        // doi gia tri thang dau tien trong nhom ve
                        if (_sumQuantity != 0)
                        {
                            _sttGroupTicket++;
                            _lstDataReport[_indexItemRptDataReport].STT = _sttGroupTicket;
                            _lstDataReport[_indexItemRptDataReport].LOAIVE = tkt.ticket_name;
                            _lstDataReport[_indexItemRptDataReport].DONGIA = tkt.ticket_value;
                            _lstDataReport[_indexItemRptDataReport].SOLUONGTONG = _sumQuantity;
                            _lstDataReport[_indexItemRptDataReport].TTIEN = _sumQuantity * tkt.ticket_value;

                            _sumQuantity = 0;
                        }

                    }
                    #endregion
                    SplashScreenManager.ShowForm(typeof(FrmSplash));
                    RptTicketStore rpt = new RptTicketStore(_lstDataReport);
                    rpt.ShowReport();
                    SplashScreenManager.CloseForm();
                }

            }
            catch (Exception)
            {
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_flag == 1 && dtGrid.Rows.Count > 0) {
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
        #endregion
    }
}
