using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nazmul.CRUDApp.Web.Models
{
    public class ProductDAL
    {
        string connectionString = "Server=NAZMUL\\SQLEXPRESS;Database=INVENTORYDB;User Id=sa;Password=123456;";
        public IEnumerable<ProductsInfo> GetAllProduct()
        {
            List<ProductsInfo> productsList = new List<ProductsInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllProducts", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductsInfo products = new ProductsInfo();
                    products.Id = Convert.ToInt32(dr["Id"].ToString());
                    products.Name = dr["Name"].ToString();
                    products.Description = dr["Description"].ToString();
                    products.Price = dr["Price"].ToString();

                    productsList.Add(products);
                }
                con.Close();
            }
            return productsList;
        }
    }
}
