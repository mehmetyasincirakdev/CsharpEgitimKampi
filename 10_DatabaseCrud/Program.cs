using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategori Ekleme İşlemi

            //Console.WriteLine("Menü Sipariş İşlem Paneli");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand command = new SqlCommand("Insert Into TblCategory (CategoryName) values (@categoryName)", sqlConnection);
            //command.Parameters.AddWithValue("categoryName", categoryName);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Kategori eklendi.");
            //sqlConnection.Close();

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("Insert Into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("productName", productName);
            //sqlCommand.Parameters.AddWithValue("productPrice", productPrice);
            //sqlCommand.Parameters.AddWithValue("productStatus", true);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı.");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("Select * From TblProduct",sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //sqlConnection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray) 
            //    {
            //        Console.WriteLine(item.ToString());
            //    }

            //}
            #endregion

            #region Ürün Silme İşlemi

            //Console.WriteLine("Silmek istediğiniz ürünün id: ");
            //int productId=int.Parse(Console.ReadLine());
            //SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //sqlConnection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct Where ProductId=@productId");
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Silme işlemi başarılı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek ürün id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek ürün adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("Update TblProduct Set=@productName,ProductPrice Where ProductId=@productId", sqlConnection);
            sqlCommand.Parameters.AddWithValue("productName", productName);
            sqlCommand.Parameters.AddWithValue("productPrice", productPrice);
            sqlCommand.Parameters.AddWithValue("productId", productId);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            #endregion
            Console.Read();
        }
    }
}
