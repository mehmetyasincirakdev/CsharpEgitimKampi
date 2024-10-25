using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado .net
            Console.WriteLine("C# Veri tabanlı Ürün-Kategori Bilgi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını girin: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine();
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From TblCategory", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var column in row.ItemArray) 
                {
                    Console.Write(column.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
