using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //}

            //CustomerList();
            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yasin");

            #endregion

            #region Geriye Değer Döndüren Metotlar
            
            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            string StudentCard()
            {
                string name = "Ali";
                string surname = "Yıldız";

                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());

            #endregion
            Console.Read();
        }
    }
}
