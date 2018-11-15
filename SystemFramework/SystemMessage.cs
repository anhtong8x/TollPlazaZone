using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemFramework
{
    public class SystemMessage
    {
        public const string fmDate = "HH:mm dd/MM/yyyy";
        public const string fmSerie = "{0}{1}=>{2}{3};";
        public const string fmMoney = "{0:0,0}";

        #region "ProjectName"
        public const string TicketStore = "Ticket Store App";
        public const string Center = "Center App";
        public const string Station = "Station App";
        #endregion

        #region "Common"
        public const string CaptionWarningMessage = "Cảnh báo";
        public const string CaptionConfirmMessage = "Xác nhận";
        public const string CaptionInfomationMessage = "Thông báo";
        #endregion

        #region "LogName"
        public const string DeleteLog = "Xóa bản ghi {0} _ bảng {1} ";
        public const string UpdateLog = " Cập nhật bản ghi {0} _ bảng {1}";
        public const string Login = "{0} đăng nhập {1} lúc {2}";
        public const string Logout = "{0} đăng xuất {1} lúc {2}";
        #endregion

        #region "LoginForm"
        public const string _title_CHUA_DANG_NHAP = "CHƯA ĐĂNG NHẬP";
        public const string _note_CHUA_DANG_NHAP = "Bạn cần đăng nhập để sử dụng hệ thống!";
        public const string _title_WELCOME = "XIN CHÀO";
        public const string WarningUsername = "Tên đăng nhập không để rỗng.";
        public const string WarningPassword = "Mật khẩu không để rỗng.";
        public const string WarningErrorUsername = "Thông tin đăng nhập không chính xác.";
        public const string WarningErrorPassword = "Mật khẩu đăng nhập không đúng.";
        public const string WarningErrorBarcode = "Mã vạch không đúng.";
        public const string WarningErrorBarcodeLogin = "Thẻ nhân viên chưa có trong CSDL của hệ thống.";
        public const string WarningUpdateDataSession = "Lỗi cập nhật phiên làm việc.";
        public const string WarningConnection = "Lỗi kết nối.";
        public const string WarningStatus = "Tài khoản này đã ngưng cấp quyền sử dụng!";
        public const string WarningAccess = "Bạn không có quyền truy cập!";
        public const string WarningConfirmPassword = "Xác nhận mật khẩu mới không đúng.";
        public const string WarningOldPassword = "Mật khẩu cũ không đúng.";
        public const string ErrorChangerPassword = "Cập nhật mật khẩu mới lỗi";

        public const string LogLoginSuccess = "Đăng nhập thành công";
        public const string LogUpdateSuccess = "Cập nhật mật khẩu thành công";
        
        #endregion

        #region "MainForm"
        public const string StatusInfo = "Xin chào: {0}";
        public const string WarningExitAppication = "Bạn đã chắc chắn thoát khỏi ứng dụng này?";
        public const string WarningCommonError = "Xảy ra lỗi: {0}";
        public const string WarningParamLaneError = "Không tồn tại cấu hình cho Làn!!!";
        public const string UpdateSuccessful = "Cập nhật thành công!!!";
        public const string InsertSuccessful = "Thêm mới thành công!!!";
        public const string ConfirmDeleteItem = "Chắc chắn bạn muốn xóa {0} này?";
        public const string DeleteSuccessful = "Xóa thành công!!!";
        public const string BarrierOpen = "BARIE MỞ";
        public const string BarrierClose = "BARIE ĐÓNG";
        #endregion

        #region "input_ticket"
        public const string WarningTableTicketTypeNull ="Bạn chưa nhập các loại vé.";
        public const string WarningTicketTypeNull = "Không có dữ liệu loại vé!";
        public const string WarningStartNumberErr = "Vé không đúng định dạng!";
        public const string WarningTicketTypeErr = "Serie không cùng loại vé!";
        public const string WarningMinMaxErr = "Serie đầu phải nhỏ hơn số cuối!";
        public const string WarningSaveDataErr = "Lỗi lưu dữ liệu vé!";
        public const string WarningSaveTicket = "Vé nhập đã có trong kho!";
        public const string WarningExitInputTicket = "Vé vừa nhập đã được nhập!";
        public const string WarningSaveSuccess = "Lưu dữ liệu vé thành công!";
        public const string WarningSaveExit = "Bạn chưa lưu dữ liệu. Bạn có muốn tiếp tục ?";

        #endregion

        #region "delivery_ticket"
        public const string WarningIsCabinNull = "Không tồn tại nhân viên bán vé.";
        public const string WarningSaveTicketDelivery = "Vé nhập đã được giao!";
        public const string WarningEmployeeNull = "Bạn chưa chọn người nhận vé!";
        #endregion


    }
}
