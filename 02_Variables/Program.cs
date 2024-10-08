using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL ");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potato + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomato + " TL ");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine(appleGram + " gram " + "Elmanın Toplam Fiyatı: " + appleTotalPrice + " TL ");
            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine(orangeGram + " Portakal Toplam Fiyat: " + orangeTotalPrice + " TL ");
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine(strawberryGram + " Çilek Toplam Fiyat: " + strawberryTotalPrice + " TL ");
            //double potatoTotalPrice = potatoGram * potato;
            //Console.WriteLine(potatoGram + " Patates Toplam Fiyat: " + potato + " TL ");
            //double tomatoTotalPrice = tomatoGram * tomato;
            //Console.WriteLine(tomatoGram + " Domates Toplam Fiyat: " + tomatoTotalPrice + " TL ");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            //Console.Read();
            #endregion

            #region CharDeğişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.Read();
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("CSharp Havayolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı:  ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe: ");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir: ");
            //passangerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("Yolcu Tc No:");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine($"Yolcu Bilgileri: {passangerName} {passangerSurname} {passangerAge} {passangerDistrict} {passangerCity} {passangerIdentityNumber}");
            //Console.Read();
            #endregion

            #region Klavyeden Tam Sayı Girişleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000; computerPrice = 1000; chairPrice = 1000; tvPrice = 1000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Ayakkabı adedi giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar adedi giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye adedi giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Televizyon adedi giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int shoesTotalPrice = shoesPrice * shoesCount;
            //int computerTotalPrice = computerPrice * computerCount;
            //int chairTotalPrice = chairPrice * chairCount;
            //int tvTotalPrice = tvPrice * tvCount;

            //int totalPrice = shoesTotalPrice + computerTotalPrice + chairTotalPrice + tvTotalPrice;
            //Console.WriteLine($"Toplam ödemeniz gereken tutar: {totalPrice} TL'dir.");

            //Console.Read();
            #endregion

            #region Klavyeden Double Değişken Girişleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine($"Sınav ortalamanız:  {result}");


            //Console.Read();
            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet giriniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            Console.ReadKey();
            #endregion
        }
    }
}
