using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları


            //Console.Write("Hello world.");
            //Console.WriteLine("Hello world");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");

            #endregion

            #region String Değişkenler

            //string name;
            //name = "Mehmet";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90546456";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim " + customerPhone);
            //Console.WriteLine("Email Adresi " + customerEmail);
            //Console.WriteLine("Adres " + district + "/" + city);

            //customerName = "Ayşegül";
            //customerSurname = "Deneme";
            //customerPhone = "+90546456";
            //customerEmail = "deneme@deneme.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim " + customerPhone);
            //Console.WriteLine("Email Adresi " + customerEmail);
            //Console.WriteLine("Adres " + district + "/" + city);

            #endregion

            #region Int Değişkenler

            //int number = 25;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Kola: " + cokePrice + " TL");
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("---- Su: " + waterPrice + " TL");
            Console.WriteLine("---- Kızarmış Ürünler: " + friesPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 3;
            lemonadeCount = 3;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalFriesPrice = friesPrice * friesCount;


            Console.WriteLine("-------------------------------- ");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL ");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL ");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL ");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL ");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalPizzaPrice + totalLemonadePrice + totalFriesPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");
            #endregion

            Console.Read();
        }
    }
}
