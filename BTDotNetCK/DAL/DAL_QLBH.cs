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
    class DAL_QLBH
    {
        private static DAL_QLBH _Instance;
        public static DAL_QLBH Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLBH();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLBH()
        {

        }

        public List<Product> GetListProducts()
        {
            List<Product> products = new List<Product>();
            string queryGetAllProducts = @"select * from HANGHOA;";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllProducts);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow r in data.Rows)
                {
                    products.Add(GetProduct(r));
                }
                return products;
            }
            else
                return null;
        }

        public List<Product> GetProductsByName(string nameProduct)
        {
            List<Product> products = new List<Product>();
            string queryGetAllProducts = @"select * from HANGHOA where TenHangHoa like N'%" + nameProduct + "%';";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllProducts);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow r in data.Rows)
                {
                    products.Add(GetProduct(r));
                }
                return products;
            }
            else
                return null;
        }

        public List<Product> SortProductsByPriceAscending()
        {
            List<Product> products = new List<Product>();
            string queryGetAllProductsByPriceAscending = @"select * from HANGHOA order by GiaTien;";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllProductsByPriceAscending);
            foreach (DataRow r in data.Rows)
            {
                products.Add(GetProduct(r));
            }
            return products;
        }

        public List<Product> SortProductsByPriceDescending()
        {
            List<Product> products = new List<Product>();
            string queryGetAllProductsByPriceDescending = @"select * from HANGHOA order by GiaTien desc;";
            DataTable data = DataProvider.Instance.GetRecords(queryGetAllProductsByPriceDescending);
            foreach (DataRow r in data.Rows)
            {
                products.Add(GetProduct(r));
            }
            return products;
        }

        public Product GetProductByID(string ID_Product)
        {
            using (SqlConnection connection = new SqlConnection(DBConnection.GetConnection()))
            {
                SqlCommand command = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "LayHangHoaTheoID",
                    Connection = connection
                };
                command.Parameters.AddWithValue("@ID_HangHoa", ID_Product);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                connection.Open();
                sqlDataAdapter.Fill(data);
                connection.Close();

                if (data.Rows.Count > 0)
                    return GetProduct(data.Rows[0]);
                else
                    return null;
            }
        }

        public int GetNumberTotalCategory()
        {
            string query = @"select count(ID_HangHoa) as TongMatHang from HANGHOA;";
            DataTable totalCategory = DataProvider.Instance.GetRecords(query);
            return Convert.ToInt32(totalCategory.Rows[0]["TongMatHang"].ToString());
        }

        public int GetNumberTotalFoodCategory()
        {
            string query = @"select count(ID_HangHoa) as TongMatHangThucAn from HANGHOA where Loai = N'Thức ăn';";
            DataTable totalFoodCategory = DataProvider.Instance.GetRecords(query);
            return Convert.ToInt32(totalFoodCategory.Rows[0]["TongMatHangThucAn"].ToString());
        }

        public int GetNumberTotalDrinkCategory()
        {
            string query = @"select count(ID_HangHoa) as TongMatHangDoUong from HANGHOA where Loai = N'Đồ uống';";
            DataTable totalDrinkCategory = DataProvider.Instance.GetRecords(query);
            return Convert.ToInt32(totalDrinkCategory.Rows[0]["TongMatHangDoUong"].ToString());
        }

        public string GetLastID()
        {
            string queryGetLastIDProduct = @"select top 1 ID_HangHoa from HANGHOA order by ID_HangHoa desc;";
            DataTable lastID = DataProvider.Instance.GetRecords(queryGetLastIDProduct);
            if (lastID.Rows[0]["ID_HangHoa"] != null)
                return lastID.Rows[0]["ID_HangHoa"].ToString();
            else
                return "H0000";
        }

        public Product GetProduct(DataRow r)
        {
            return new Product
            {
                ID_Product = r["ID_HangHoa"].ToString(),
                NameProduct = r["TenHangHoa"].ToString(),
                Category = r["Loai"].ToString(),
                QuantitySold = Convert.ToInt32(r["SoLuongDaBan"].ToString()),
                Price = Convert.ToInt32(r["GiaTien"].ToString()),
                Image = r["Anh"].ToString(),
            };
        }

        public bool AddProduct(Product product)
        {
            string queryAddNewProduct = @"insert into HANGHOA (ID_HangHoa, TenHangHoa, Loai, SoLuongDaBan, GiaTien, Anh) " +
                "values ('" + product.ID_Product + "', N'" + product.NameProduct + "', N'" + product.Category + "', " + 
                            product.QuantitySold + ", " + product.Price + ", '" + product.Image + "')";
            if (DataProvider.Instance.ExecuteDB(queryAddNewProduct) != -1)
                return true;
            else
                return false;
        }

        public bool UpdateProduct(Product product)
        {
            string queryUpdateProduct = @"update HANGHOA set TenHangHoa = N'" + product.NameProduct + 
                                            "', Loai = N'" + product.Category + "', GiaTien = '" + product.Price + 
                                            "' where ID_HangHoa = '" + product.ID_Product + "';";
            if (DataProvider.Instance.ExecuteDB(queryUpdateProduct) != -1)
                return true;
            else
                return false;
        }

        public bool DeleteProduct(string ID_Product)
        {
            string queryDeleteProduct = @"delete from HANGHOA where ID_HangHoa = '" + ID_Product + "';";
            if (DataProvider.Instance.ExecuteDB(queryDeleteProduct) != -1)
                return true;
            else
                return false;
        }
    }
}
