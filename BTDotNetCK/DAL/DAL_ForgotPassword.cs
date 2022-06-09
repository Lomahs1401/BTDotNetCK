using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BTDotNetCK.DAL
{
    class DAL_ForgotPassword
    {
        private static DAL_ForgotPassword _Instance;
        public static DAL_ForgotPassword Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ForgotPassword();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_ForgotPassword()
        {

        }

        public string CheckEmail(string email, string emailPassword)
        {
            string queryGetEmail = "select Email from NhanVienQuanLy where Email = '" + email + "'";
            DataTable listEmail = DataProvider.Instance.GetRecords(queryGetEmail);
            if (listEmail.Rows.Count == 0)
                return "Không tìm thấy email trong hệ thống";
            else
            {
                string queryGetUsername = "select TenDangNhap from NhanVienQuanLy where Email = '" + email + "'";
                DataTable username = DataProvider.Instance.GetRecords(queryGetUsername);

                string queryGetPassword = "select MatKhau from TAIKHOAN where TenDangNhap = '" + username.Rows[0]["TenDangNhap"].ToString() + "'";
                DataTable password = DataProvider.Instance.GetRecords(queryGetPassword);

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("CoffeeStore@gmail.com");
                mailMessage.To.Add(email);
                mailMessage.Body = "Mật khẩu của bạn là: " + password.Rows[0]["MatKhau"].ToString();
                mailMessage.Subject = "Nhắc nhở mật khẩu";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(email, emailPassword)
                };
                try
                {
                    smtp.Send(mailMessage);
                    return "Gửi mã thành công. Vui lòng check mail";
                }
                catch (Exception)
                {
                    return "Hệ thống gửi mail đang bảo trì. Vui lòng thử lại sau";
                }
            }
        }
    }
}
