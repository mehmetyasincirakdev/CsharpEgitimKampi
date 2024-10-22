using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 14, 16, 18 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 14, 16, 18 };
            //int total = 0;

            //foreach (var number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach (char c in word) 
            //{ 
            //    Console.WriteLine(c); 
            //}




            #endregion

            #region Örnek Sınav Sistemi

            Console.WriteLine("C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Sınıfızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAverage[i]}");
                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti. ");
                }

                else
                {
                    Console.WriteLine("${studentNames[i]} adlı öğrenci dersten kaldı.");
                }
            }











            #endregion

            Console.Read();
        }
    }
}
