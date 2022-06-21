using BTDotNetCK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDotNetCK.DAL
{
    class DAL_QLNV
    {
        private static DAL_QLNV _Instance;
        public static DAL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLNV()
        {

        }

        public List<Staff> GetListStaffs()
        {
            List<Staff> staffs = new List<Staff>();
            string queryGetAllStaffs = @"select * from NhanVienQuanLy where TenDangNhap in 
                                            (select TenDangNhap from TAIKHOAN where Quyen = '1');";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllStaffs);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow r in data.Rows)
                {
                    staffs.Add(GetStaff(r));
                }
                return staffs;
            }
            else
                return null;
        }

        public List<Staff> GetListStaffByName(string nameStaff)
        {
            List<Staff> staffs = new List<Staff>();
            string queryGetAllStaffsByName = @"select * from NhanVienQuanLy where HoVaTen like N'%" + nameStaff + "%' " +
                                                "and TenDangNhap in (select TenDangNhap from TAIKHOAN where Quyen = '1');";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllStaffsByName);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow r in data.Rows)
                {
                    staffs.Add(GetStaff(r));
                }
                return staffs;
            }
            else
                return null;
        }

        public Staff GetStaffByID(string id)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "LayNhanVienTheoID",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@ID_QuanLy", id);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                    return GetStaff(data.Rows[0]);
                else
                    return null;
            }
        }

        public Staff GetStaffByPhone(string phone)
        {
            string queryGetAllStaffsByPhone = @"select * from NhanVienQuanLy where SDT = '" + phone + "' " +
                                                "and TenDangNhap in (select TenDangNhap from TAIKHOAN where Quyen = '1');";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllStaffsByPhone);
            if (data.Rows.Count > 0)
                return GetStaff(data.Rows[0]);
            else
                return null;
        }

        public string GetAccountUsernameStaffByID(string ID_Staff)
        {
            string queryGetAccountUsernameByID = @"select TenDangNhap from NhanVienQuanLy where ID_QuanLy = '" + ID_Staff + "';";
            DataTable accountUsername = DataProvider.Instance.GetRecords(queryGetAccountUsernameByID);
            return accountUsername.Rows[0]["TenDangNhap"].ToString();
        }

        public string GetImage(string accountUsername)
        {
            string queryGetImage = @"select Anh from TAIKHOAN where TenDangNhap = '" + accountUsername + "';";
            DataTable image = DataProvider.Instance.GetRecords(queryGetImage);
            return image.Rows[0]["Anh"].ToString();
        }

        public int GetNumberTotalStaff()
        {
            string queryGetNumberStaff = @"select count(ID_QuanLy) as TongNhanVien from NhanVienQuanLy 
                                            where TenDangNhap in (select TenDangNhap from TAIKHOAN where Quyen = '1');";
            DataTable totalStaff = DataProvider.Instance.GetRecords(queryGetNumberStaff);
            return Convert.ToInt32(totalStaff.Rows[0]["TongNhanVien"].ToString());
        }

        public int GetNumberTotalMaleStaff()
        {
            string queryGetNumberMaleStaff = @"select count(ID_QuanLy) as TongNhanVienNam from NhanVienQuanLy where GioiTinh = 'Nam' 
                                                and TenDangNhap in (select TenDangNhap from TAIKHOAN where Quyen = '1');";
            DataTable totalMaleStaff = DataProvider.Instance.GetRecords(queryGetNumberMaleStaff);
            return Convert.ToInt32(totalMaleStaff.Rows[0]["TongNhanVienNam"].ToString());
        }

        public int GetNumberTotalFemaleStaff()
        {
            string queryGetNumberFemaleStaff = @"select count(ID_QuanLy) as TongNhanVienNu from NhanVienQuanLy where GioiTinh = N'Nữ' 
                                                and TenDangNhap in (select TenDangNhap from TAIKHOAN where Quyen = '1');";
            DataTable totalFemaleStaff = DataProvider.Instance.GetRecords(queryGetNumberFemaleStaff);
            return Convert.ToInt32(totalFemaleStaff.Rows[0]["TongNhanVienNu"].ToString());
        }

        public string GetLastID()
        {
            string queryGetLastIDStaff = @"select top 1 ID_QuanLy from NhanVienQuanLy order by ID_QuanLy desc;";
            DataTable lastID = DataProvider.Instance.GetRecords(queryGetLastIDStaff);
            if (lastID.Rows[0]["ID_QuanLy"] != null)
                return lastID.Rows[0]["ID_QuanLy"].ToString();
            else
                return "S0000";
        }

        public Staff GetStaff(DataRow r)
        {
            return new Staff
            {
                ID_Staff = r["ID_QuanLy"].ToString(),
                NameStaff = r["HoVaTen"].ToString(),
                Email = r["Email"].ToString(),
                DateOfBirth = (DateTime)r["NgaySinh"],
                Gender = r["GioiTinh"].ToString(),
                Phone = r["SDT"].ToString(),
                ID_Card = r["SoCCCD"].ToString(),
                Address = r["DiaChi"].ToString(),
                StartDate = (DateTime)r["NgayVaoLam"],
                EndDate = r["NgayNghiViec"] == DBNull.Value ? (DateTime?)null : (DateTime)r["NgayNghiViec"],
                Image = r["Anh"].ToString(),
                AccountUsername = r["TenDangNhap"].ToString(),
            };
        }

        public bool AddStaff(Staff staff, string username, string password)
        {
            string queryAddNewStaffAccount = @"insert into TAIKHOAN (TenDangNhap, MatKhau, Quyen) " +
                "values ('" + username + "', '" + password + "', '1')";
            string queryAddNewStaff = @"insert into NhanVienQuanLy (ID_QuanLy, HoVaTen, Email, NgaySinh, NgayVaoLam, NgayNghiViec, GioiTinh, SDT, SoCCCD, DiaChi, Anh, TenDangNhap) " +
                "values ('" + staff.ID_Staff + "', N'" + staff.NameStaff + "', '" + staff.Email + "', '" + staff.DateOfBirth + "', '" 
                            + staff.StartDate + "', '" + staff.EndDate + "', N'" + staff.Gender + "', '" + staff.Phone + "', '"
                            + staff.ID_Card + "', N'" + staff.Address + "', '" + staff.Image + "', '" + username + "')";
            if (DataProvider.Instance.ExecuteDB(queryAddNewStaffAccount) != -1 && DataProvider.Instance.ExecuteDB(queryAddNewStaff) != -1)
                return true;
            else
                return false;
        }

        public bool UpdateStaff(Staff staff)
        {
            string queryUpdateStaff = @"update NhanVienQuanLy set HoVaTen = N'" + staff.NameStaff + "', Email = '" + staff.Email + 
                "', NgaySinh = '" + staff.DateOfBirth + "', GioiTinh = N'" + staff.Gender + "', SDT = '" + staff.Phone + 
                "', SoCCCD = '" + staff.ID_Card + "', DiaChi = N'" + staff.Address + "', Anh = '" + staff.Image + 
                "' where ID_QuanLy = '" + staff.ID_Staff + "';";
            if (DataProvider.Instance.ExecuteDB(queryUpdateStaff) != -1)
                return true;
            else
                return false;
        }

        public bool DelelteStaff(string accountUsername)
        {
            string queryDeleteAccount = @"delete from TAIKHOAN where TenDangNhap = '" + accountUsername + "';";
            if (DataProvider.Instance.ExecuteDB(queryDeleteAccount) != -1)
                return true;
            else
                return false;
        }
    }
}
