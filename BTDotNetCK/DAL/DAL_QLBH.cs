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

                return GetProduct(data.Rows[0]);
            }
        }

        public Product GetProduct(DataRow r)
        {
            return new Product
            {
                ID_Product = r["ID_HangHoa"].ToString(),
                NameProduct = r["TenHangHoa"].ToString(),
                QuantitySold = Convert.ToInt32(r["SoLuongDaBan"].ToString()),
                Price = Convert.ToInt32(r["GiaTien"].ToString()),
                Image = r["Anh"].ToString(),
            };
        }
    }
}
