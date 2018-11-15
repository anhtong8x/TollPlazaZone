using DataBaseTollPlaza.EF;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Reports
{
    public class RptTicketStore
    {
        List<RptTicketStoreModel> _lstRptTicketStoreModel;
        public RptTicketStore (List<RptTicketStoreModel> lst) { _lstRptTicketStoreModel = lst; }
        public void ShowReport() {
            #region "create_band"            
            TopMarginBand TopMargin = new TopMarginBand();
            BottomMarginBand BottomMargin = new BottomMarginBand();
            DetailBand Detail = new DetailBand(); // noi dung lap lai
            ReportHeaderBand ReportHeader = new ReportHeaderBand(); // khong lap lai lam ten report
            PageHeaderBand PageHeader = new PageHeaderBand(); // lap lai tieu de
            ReportFooterBand ReportFooter = new ReportFooterBand(); // khong lap lai de lay chu ky
            #endregion

            #region "TopMargin"
            TopMargin.HeightF = 100F;
            TopMargin.Name = "TopMargin";
            TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            #endregion

            #region "ReportHeader"
            XRLabel xrLbl_BOT = new XRLabel();
            XRLabel xrLblCongHoa = new XRLabel();
            XRLabel xrLblDocLap = new XRLabel();
            XRLabel xrLblMau = new XRLabel();
            XRLabel xrLblBaoCao = new XRLabel();

            ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrLbl_BOT,
            xrLblCongHoa,
            xrLblDocLap,
            xrLblMau,
            xrLblBaoCao});
            ReportHeader.HeightF = 185.9375F;
            ReportHeader.Name = "ReportHeader";

            // 
            // xrLbl_BOT
            // 
            xrLbl_BOT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLbl_BOT.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrLbl_BOT.Multiline = true;
            xrLbl_BOT.Name = "xrLbl_BOT";
            xrLbl_BOT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLbl_BOT.SizeF = new System.Drawing.SizeF(227.6882F, 47.19355F);
            xrLbl_BOT.StylePriority.UseFont = false;
            xrLbl_BOT.StylePriority.UseTextAlignment = false;
            xrLbl_BOT.Text = "TRẠM THU PHÍ BOT \r\nCẦU BẠCH ĐĂNG";
            xrLbl_BOT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLblCongHoa
            // 
            xrLblCongHoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLblCongHoa.LocationFloat = new DevExpress.Utils.PointFloat(401.8818F, 0F);
            xrLblCongHoa.Multiline = true;
            xrLblCongHoa.Name = "xrLblCongHoa";
            xrLblCongHoa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLblCongHoa.SizeF = new System.Drawing.SizeF(567.1182F, 32.4086F);
            xrLblCongHoa.StylePriority.UseFont = false;
            xrLblCongHoa.StylePriority.UseTextAlignment = false;
            xrLblCongHoa.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM ";
            xrLblCongHoa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLblDocLap
            // 
            xrLblDocLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLblDocLap.LocationFloat = new DevExpress.Utils.PointFloat(401.8818F, 32.4086F);
            xrLblDocLap.Multiline = true;
            xrLblDocLap.Name = "xrLblDocLap";
            xrLblDocLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLblDocLap.SizeF = new System.Drawing.SizeF(567.1182F, 32.4086F);
            xrLblDocLap.StylePriority.UseFont = false;
            xrLblDocLap.StylePriority.UseTextAlignment = false;
            xrLblDocLap.Text = "Độc lâp - Tự do - Hạnh phúc ";
            xrLblDocLap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLblMau
            // 
            xrLblMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLblMau.LocationFloat = new DevExpress.Utils.PointFloat(401.8818F, 78.10752F);
            xrLblMau.Multiline = true;
            xrLblMau.Name = "xrLblMau";
            xrLblMau.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLblMau.SizeF = new System.Drawing.SizeF(567.1182F, 32.4086F);
            xrLblMau.StylePriority.UseFont = false;
            xrLblMau.StylePriority.UseTextAlignment = false;
            xrLblMau.Text = "Mẫu: PN KT-001\r\n";
            xrLblMau.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLblBaoCao
            // 
            xrLblBaoCao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLblBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 123.6559F);
            xrLblBaoCao.Multiline = true;
            xrLblBaoCao.Name = "xrLblBaoCao";
            xrLblBaoCao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLblBaoCao.SizeF = new System.Drawing.SizeF(968.9999F, 40.47312F);
            xrLblBaoCao.StylePriority.UseFont = false;
            xrLblBaoCao.StylePriority.UseTextAlignment = false;
            xrLblBaoCao.Text = "BÁO CÁO NHẬP KHO VÉ\r\n";
            xrLblBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            #endregion

            #region "PageHeader"
            XRTable xrTable_Title = new XRTable();
            XRTableRow xrTableRow1 = new XRTableRow();
            XRTableCell xrTableCell_STT = new XRTableCell();
            XRTableCell xrTableCell_LoaiVe = new XRTableCell();
            XRTableCell xrTableCell_DonGia = new XRTableCell();
            XRTableCell xrTableCell_SoLuong = new XRTableCell();
            XRTableCell xrTableCell_SoSerie = new XRTableCell();
            XRTableCell xrTableCell_ThanhTien = new XRTableCell();

            PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable_Title});
            PageHeader.HeightF = 35.7527F;
            PageHeader.Name = "PageHeader";

            xrTable_Title.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTable_Title.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTable_Title.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrTable_Title.Name = "xrTable_Title";
            xrTable_Title.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow1});
            xrTable_Title.SizeF = new System.Drawing.SizeF(968.9999F, 35.7527F);
            xrTable_Title.StylePriority.UseBorders = false;
            xrTable_Title.StylePriority.UseFont = false;
            xrTable_Title.StylePriority.UseTextAlignment = false;
            xrTable_Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell_STT,
            xrTableCell_LoaiVe,
            xrTableCell_DonGia,
            xrTableCell_SoLuong,
            xrTableCell_SoSerie,
            xrTableCell_ThanhTien});
            xrTableRow1.Name = "xrTableRow1";
            xrTableRow1.Weight = 1D;
            // 
            // xrTableCell_STT
            // 
            xrTableCell_STT.Name = "xrTableCell_STT";
            xrTableCell_STT.Text = "STT";
            xrTableCell_STT.Weight = 0.55645156860351563D;
            // 
            // xrTableCell_LoaiVe
            // 
            xrTableCell_LoaiVe.Name = "xrTableCell_LoaiVe";
            xrTableCell_LoaiVe.Text = "Loại vé";
            xrTableCell_LoaiVe.Weight = 3.2123664541018107D;
            // 
            // xrTableCell_DonGia
            // 
            xrTableCell_DonGia.Name = "xrTableCell_DonGia";
            xrTableCell_DonGia.Text = "Đơn giá";
            xrTableCell_DonGia.Weight = 0.95161227514623636D;
            // 
            // xrTableCell_SoLuong
            // 
            xrTableCell_SoLuong.Name = "xrTableCell_SoLuong";
            xrTableCell_SoLuong.Text = "Số lượng";
            xrTableCell_SoLuong.Weight = 0.63216863614925811D;
            // 
            // xrTableCell_SoSerie
            // 
            xrTableCell_SoSerie.Name = "xrTableCell_SoSerie";
            xrTableCell_SoSerie.Text = "Số serie nhập";
            xrTableCell_SoSerie.Weight = 3.0255367900463437D;
            // 
            // xrTableCell_ThanhTien
            // 
            xrTableCell_ThanhTien.Name = "xrTableCell_ThanhTien";
            xrTableCell_ThanhTien.Text = "Thành tiền";
            xrTableCell_ThanhTien.Weight = 1.3118642759528358D;

            #endregion

            #region "Detail"

            List<RptTicketStoreModel> lst = new List<RptTicketStoreModel>();
            #region "Create_Data"
            // L1
            lst.Add(new RptTicketStoreModel()
            {
                STT = 1,
                LOAIVE = "Vé lượt < 12 chỗ ngồi",
                DONGIA = 35000,
                SOLUONGTONG = 30,
                SOLUONGSERIE = 10,
                SOSERIE = "VL/18P02110000001=>VL/18P02110000010;",
                TTIEN = 1050000
            });
            lst.Add(new RptTicketStoreModel()
            {
                STT = -1,
                LOAIVE = "",
                DONGIA = -1,
                SOLUONGTONG = -1,
                SOLUONGSERIE = 15,
                SOSERIE = "VL/18P021100000011=>VL/18P02110000025;",
                TTIEN = -1
            });
            lst.Add(new RptTicketStoreModel()
            {
                STT = -1,
                LOAIVE = "",
                DONGIA = -1,
                SOLUONGTONG = -1,
                SOLUONGSERIE = 5,
                SOSERIE = "VL/18P021100000026=>VL/18P02110000030;",
                TTIEN = -1
            });
            // L2
            lst.Add(new RptTicketStoreModel()
            {
                STT = 2,
                LOAIVE = "Vé lượt xe từ 12 ghế đến 30 ghế",
                DONGIA = 50000,
                SOLUONGTONG = 10,
                SOLUONGSERIE = 3,
                SOSERIE = "VL/18P02120000001=>VL/18P0212000003;",
                TTIEN = 150000
            });
            lst.Add(new RptTicketStoreModel()
            {
                STT = -1,
                LOAIVE = "",
                DONGIA = -1,
                SOLUONGTONG = -1,
                SOLUONGSERIE = 4,
                SOSERIE = "VL/18P02120000004=>VL/18P0212000007;",
                TTIEN = -1
            });
            lst.Add(new RptTicketStoreModel()
            {
                STT = -1,
                LOAIVE = "",
                DONGIA = -1,
                SOLUONGTONG = -1,
                SOLUONGSERIE = 3,
                SOSERIE = "VL/18P02120000008=>VL/18P02120000010;",
                TTIEN = -1
            });

            // L3
            lst.Add(new RptTicketStoreModel()
            {
                STT = 3,
                LOAIVE = "Vé lượt xe từ 31 ghế trở lên",
                DONGIA = 60000,
                SOLUONGTONG = 5,
                SOLUONGSERIE = 5,
                SOSERIE = "VL/18P02130000001=>VL/18P0213000005;",
                TTIEN = 300000
            });
            #endregion

            XRTable xrTable_Detail = new XRTable();
            XRTableRow xrTableRow2;

            XRTableCell xrTableCell_STT_;
            XRTableCell xrTableCell_LoaiVe_;
            XRTableCell xrTableCell_DonGia_;
            XRTableCell xrTableCell_SoLuong_;
            XRTableCell xrTableCell_SoLuongSerie;
            XRTableCell xrTableCell_Serie_;
            XRTableCell xrTableCell_ThanhTien_;


            int tmpSL = 0;
            decimal tmpTT = 0;

            foreach (RptTicketStoreModel item in _lstRptTicketStoreModel)
            {
                xrTableRow2 = new XRTableRow();
                xrTableCell_STT_ = new XRTableCell();
                xrTableCell_LoaiVe_ = new XRTableCell();
                xrTableCell_DonGia_ = new XRTableCell();
                xrTableCell_SoLuong_ = new XRTableCell();
                xrTableCell_SoLuongSerie = new XRTableCell();
                xrTableCell_Serie_ = new XRTableCell();
                xrTableCell_ThanhTien_ = new XRTableCell();

                #region "format_cell"
                // 
                // xrTableCell_STT_
                // 
                xrTableCell_STT_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTableCell_STT_.Name = "xrTableCell_STT_";
                //xrTableCell_STT_.Text = "STT";
                xrTableCell_STT_.Weight = 0.55645156860351563D;
                // 
                // xrTableCell_LoaiVe_
                // 
                xrTableCell_LoaiVe_.Name = "xrTableCell_LoaiVe_";
                xrTableCell_LoaiVe_.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                xrTableCell_LoaiVe_.Weight = 3.2123664541018107D;
                xrTableCell_LoaiVe_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                // 
                // xrTableCell_DonGia_
                // 
                xrTableCell_DonGia_.Name = "xrTableCell_DonGia_";
                xrTableCell_DonGia_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTableCell_DonGia_.Weight = 0.95161227514623636D;
                // 
                // xrTableCell_SoLuong_
                // 
                xrTableCell_SoLuong_.Name = "xrTableCell_SoLuong_";
                xrTableCell_SoLuong_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTableCell_SoLuong_.Weight = 0.63216863614925807D;
                // 
                // xrTableCell_Serie_
                // 
                xrTableCell_Serie_.Name = "xrTableCell_Serie_";
                xrTableCell_Serie_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTableCell_Serie_.Weight = 2.393366452796194D;
                // 
                // xrTableCell_ThanhTien_
                // 
                xrTableCell_ThanhTien_.Name = "xrTableCell_ThanhTien_";
                xrTableCell_ThanhTien_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTableCell_ThanhTien_.Weight = 1.3118641235159838D;
                // 
                // xrTableCell_SoLuongSerie
                // 
                xrTableCell_SoLuongSerie.Name = "xrTableCell_SoLuongSerie";
                xrTableCell_SoLuongSerie.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTableCell_SoLuongSerie.Weight = 0.63216863614925811D;


                #endregion

                #region "Binding_data_to_cell"
                xrTableCell_STT_.Text = "" + item.STT;
                xrTableCell_LoaiVe_.Text = "  " + item.LOAIVE;
                xrTableCell_DonGia_.Text = string.Format("{0:0,0}",item.DONGIA);
                xrTableCell_SoLuong_.Text = "" + item.SOLUONGTONG;
                xrTableCell_SoLuongSerie.Text = "" + item.SOLUONGSERIE;
                xrTableCell_Serie_.Text = item.SOSERIE;
                xrTableCell_ThanhTien_.Text = string.Format("{0:0,0}",item.TTIEN);

                if (item.STT != -1)
                {
                    tmpSL += item.SOLUONGTONG;
                    tmpTT += item.TTIEN;
                }

                if (item.STT == -1)
                {
                    xrTableCell_STT_.Text = "";
                    xrTableCell_LoaiVe_.Text = "";
                    xrTableCell_DonGia_.Text = "";
                    xrTableCell_SoLuong_.Text = "";
                    xrTableCell_SoLuongSerie.Text = "" + item.SOLUONGSERIE;
                    xrTableCell_Serie_.Text = item.SOSERIE;
                    xrTableCell_ThanhTien_.Text = "";

                    xrTableCell_STT_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
                    xrTableCell_LoaiVe_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
                    xrTableCell_DonGia_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
                    xrTableCell_SoLuong_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
                    xrTableCell_ThanhTien_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
                }

                if (item.STT > 1)
                {
                    xrTableCell_STT_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
                    xrTableCell_LoaiVe_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
                    xrTableCell_DonGia_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
                    xrTableCell_SoLuong_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
                    xrTableCell_SoLuongSerie.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
                    xrTableCell_Serie_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
                    xrTableCell_ThanhTien_.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));


                }


                #endregion

                #region "Add_Cell_To_xrTableRows"
                // 
                // xrTableRow2
                // 
                xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell_STT_,
            xrTableCell_LoaiVe_,
            xrTableCell_DonGia_,
            xrTableCell_SoLuong_,
            xrTableCell_SoLuongSerie,
            xrTableCell_Serie_,
            xrTableCell_ThanhTien_});
                xrTableRow2.Name = "xrTableRow2";
                xrTableRow2.Weight = 1D;

                #endregion

                #region "Add_Row_To_xrTable"
                // 
                // xrTable_Detail. 
                // 
                //xrTable_Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                //| DevExpress.XtraPrinting.BorderSide.Bottom)));
                xrTable_Detail.Borders = DevExpress.XtraPrinting.BorderSide.None;
                xrTable_Detail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                xrTable_Detail.LocationFloat = new DevExpress.Utils.PointFloat(0.0001390775F, 0F);
                xrTable_Detail.Name = "xrTable_Detail";
                xrTable_Detail.SizeF = new System.Drawing.SizeF(968.9997F, 35.7527F);
                xrTable_Detail.StylePriority.UseBorders = false;
                xrTable_Detail.StylePriority.UseFont = false;
                xrTable_Detail.StylePriority.UseTextAlignment = false;
                xrTable_Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                xrTable_Detail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow2});
                #endregion

            }

            // add table to Band_Detail            
            Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable_Detail});
            Detail.HeightF = 35.7527F;
            Detail.Name = "Detail";
            Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;

            #endregion

            #region "ReportFooter"
            XRTable xrTable_footer = new XRTable();
            XRTableRow xrTableRow3 = new XRTableRow();
            XRTableCell xrTableCell_Tong = new XRTableCell();
            XRTableCell xrTableCell_SoLuongSum = new XRTableCell();
            XRTableCell xrTableCell_TTSum = new XRTableCell();
            // 
            // xrTable_footer
            // 
            xrTable_footer.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Top)));
            xrTable_footer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTable_footer.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrTable_footer.Name = "xrTable_footer";
            xrTable_footer.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            xrTableRow3});
            xrTable_footer.SizeF = new System.Drawing.SizeF(968.9995F, 35.7527F);
            xrTable_footer.StylePriority.UseBorders = false;
            xrTable_footer.StylePriority.UseFont = false;
            xrTable_footer.StylePriority.UseTextAlignment = false;
            xrTable_footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            xrTableCell_Tong,
            xrTableCell_SoLuongSum,
            xrTableCell_TTSum});
            xrTableRow3.Name = "xrTableRow3";
            xrTableRow3.Weight = 1D;
            // 
            // xrTableCell_Tong
            // 
            //xrTableCell_Tong.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top)
            //| DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCell_Tong.Name = "xrTableCell_Tong";
            xrTableCell_Tong.StylePriority.UseBorders = false;
            xrTableCell_Tong.Text = "TỔNG";
            xrTableCell_Tong.Weight = 4.7204276039877069D;
            // 
            // xrTableCell_SoLuongSum
            // 
            //xrTableCell_SoLuongSum.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top)
            //| DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCell_SoLuongSum.Name = "xrTableCell_SoLuongSum";
            xrTableCell_SoLuongSum.StylePriority.UseBorders = false;
            xrTableCell_SoLuongSum.Text = "" + tmpSL;// "000";
            xrTableCell_SoLuongSum.Weight = 0.6321689989974304D;
            // 
            // xrTableCell_TTSum
            // 
            xrTableCell_TTSum.Name = "xrTableCell_TTSum";
            xrTableCell_TTSum.StylePriority.UseTextAlignment = false;
            xrTableCell_TTSum.Text = string.Format("{0:0,0}", tmpTT);//"000.000.000.000  ";
            xrTableCell_TTSum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            xrTableCell_TTSum.Weight = 4.3373998019691911D;
            // 
            // xrLbl_NguoiLap
            // 
            XRLabel xrLbl_NguoiLap = new XRLabel();
            xrLbl_NguoiLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLbl_NguoiLap.LocationFloat = new DevExpress.Utils.PointFloat(777.0834F, 78.34375F);
            xrLbl_NguoiLap.Name = "xrLbl_NguoiLap";
            xrLbl_NguoiLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            xrLbl_NguoiLap.SizeF = new System.Drawing.SizeF(100F, 23F);
            xrLbl_NguoiLap.StylePriority.UseFont = false;
            xrLbl_NguoiLap.StylePriority.UseTextAlignment = false;
            xrLbl_NguoiLap.Text = "NGƯỜI LẬP";
            xrLbl_NguoiLap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            // 
            // xrLblNgayThang
            // 
            XRLabel xrLblNgayThang = new DevExpress.XtraReports.UI.XRLabel();
            xrLblNgayThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrLblNgayThang.LocationFloat = new DevExpress.Utils.PointFloat(677.0834F, 55.34375F);
            xrLblNgayThang.Name = "xrLblNgayThang";
            xrLblNgayThang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrLblNgayThang.SizeF = new System.Drawing.SizeF(291.9162F, 23F);
            xrLblNgayThang.StylePriority.UseFont = false;
            xrLblNgayThang.StylePriority.UseTextAlignment = false;
            xrLblNgayThang.Text = ",ngày    tháng    năm";
            xrLblNgayThang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable_footer,
            xrLblNgayThang,
            xrLbl_NguoiLap});
            ReportFooter.HeightF = 217.1875F;
            ReportFooter.Name = "ReportFooter";

            #endregion

            #region "BottomMargin"

            XRPageInfo xrPageInfo1 = new XRPageInfo();

            // 
            // xrPageInfo1
            // 
            xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrPageInfo1.Format = "Page{0}/{1}";
            xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(859F, 0F);
            xrPageInfo1.Name = "xrPageInfo1";
            xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            xrPageInfo1.StylePriority.UseFont = false;
            xrPageInfo1.StylePriority.UseTextAlignment = false;
            xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;


            BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrPageInfo1});
            BottomMargin.HeightF = 83.07291F;
            BottomMargin.Name = "BottomMargin";
            BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;

            #endregion

            #region "create_report"
            XtraReport rpt = new XtraReport();
            rpt.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            Detail,
            TopMargin,
            BottomMargin,
            ReportHeader,
            PageHeader,
            ReportFooter});
            rpt.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 100); // can le. left - right - top - bottom
            rpt.Landscape = true; // giay ngang
            rpt.PageHeight = 827; // kich thuoc trang xoay ngang
            rpt.PageWidth = 1169; // doi height va width se la A4 doc
            rpt.PaperKind = System.Drawing.Printing.PaperKind.A4; // set giay A4
            rpt.Version = "17.1";
            #endregion

            #region "show_report"
            ReportPrintTool reportPrintTool = new ReportPrintTool(rpt);
            reportPrintTool.ShowPreviewDialog();
            #endregion
        }
    }

    // class model report
    public class RptTicketStoreModel
    {
        public int STT { get; set; }
        public string LOAIVE { get; set; }
        public decimal DONGIA { get; set; }
        public int SOLUONGTONG { get; set; }
        public int SOLUONGSERIE { get; set; }
        public string SOSERIE { get; set; }
        public decimal TTIEN { get; set; }
        
    }
}
