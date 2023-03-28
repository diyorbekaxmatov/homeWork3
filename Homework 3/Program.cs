using Microsoft.Win32.SafeHandles;
using System.ComponentModel.DataAnnotations;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //Console.Write(" Enter number : ");
            //string son = Console.ReadLine();
            //int raqam;
            //bool isnumber = int.TryParse(son, out raqam);
            //if (isnumber)
            //{
            //    string binaryNUmber = Convert.ToString(raqam, 2);
            //    Console.WriteLine("BinaryNumber: " + binaryNUmber);
            //}
            //else
            //{
            //    Console.WriteLine(" Faqat son butun son kirita olasz !!!");
            //}
            //Main(args);


            ////2
            //Console.Write(" son kiriting: ");
            //string son = Console.ReadLine();
            //bool isnumber = int.TryParse(son, out int raqam);
            //int faktorial = 1;
            //if (isnumber )
            //{
            //    for(int i=1;i<=raqam;i++)
            //    {
            //        faktorial *= i;
            //    }
            //    Console.WriteLine($"{" Faktoriali: "}{faktorial}");
            //}
            //else
            //{
            //    Console.Write(" Faqat son butun son kirita olasz !!!");
            //}
            //Main(args);

            //3
            //Console.Write(" 1 number: ");
            //string son1 = Console.ReadLine();
            //bool isnumber1 = double.TryParse(son1, out double number1);
            //if (isnumber1) {
            //    Console.Write(" 2number: ");
            //    string son2 = Console.ReadLine();
            //    bool isnumber2 = double.TryParse(son2, out double number2);
            //    if (isnumber2) {
            //        Console.Write(" 3 number: ");
            //        string son3 = Console.ReadLine();
            //        bool isnumber3 = double.TryParse(son3, out double number3);
            //        if (isnumber3) {
            //            Console.Write(" 4 number: ");
            //            string son4 = Console.ReadLine();
            //            bool isnumber4 = double.TryParse(son4, out double number4);
            //            if (isnumber4) {
            //double max=    Math.Max(Math.Max(number1,number2),Math.Max(number3,number4));
            //                Console.WriteLine(" Maximum: " + max);
            //double min=    Math.Min(Math.Min(number1,number2),Math.Min(number3,number4));
            //                Console.WriteLine( " Minimum: "+min);
            //                Console.WriteLine($"{" Ayirmasi: "}{max}-{min}={max - min}");
            //            }
            //            else
            //            {
            //                Console.WriteLine(" Faqat son kirita olasiz !!!");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine(" Faqat son kirita olasiz !!!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Faqat son kirita olasiz !!!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Faqat son kirita olasiz !!!");
            //}
            //Main(args);

            ////4
            // Console.Write(" son kiriting: ");
            // string son = Console.ReadLine();
            // bool isnumber = int.TryParse(son, out int raqam);
            // if (isnumber)
            // {
            //     for(int i=1;i< 100;i++)
            //     {
            //         if (i % raqam == 0 && i % 2 == 0)
            //         {
            //             Console.Write(" " + i);
            //         }
            //     }
            // }
            // else
            // {
            //     Console.WriteLine(" Faqat butun son kirita olasz !!!");
            // }
            // Main(args);

            ////6
            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(i*j+" ");
            //    }
            //    Console.WriteLine();
            //}

            ////7
            //Console.Write(" son kiriting: ");
            //string son = Console.ReadLine();
            //bool isnumber = int.TryParse(son, out int raqam);
            //int faktorial = 1;
            //if (isnumber)
            //{
            //    for (int i = 1; i <= raqam; i++)
            //    {
            //        faktorial *= i;
            //    }
            //    Console.WriteLine($"{" Faktoriali: "}{faktorial}");
            //}
            //else
            //{
            //    Console.Write(" Faqat son butun son kirita olasz !!!");
            //}
            //Main(args);

            ////8
            //Console.Write(" 1 son kiriting: ");
            //string son=Console.ReadLine();
            //bool isnumber =int.TryParse(son, out int  number);
            //Console.Write(" 2 son kiriting: ");
            //string sonn = Console.ReadLine();
            //bool isnumber2=int.TryParse(sonn, out int number2);
            //if(isnumber&&isnumber2) {
            //    for (int i; number<=number2;number++)
            //    {
            //        if(number2%number==0)
            //        {
            //            Console.Write(number+  " ");
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine(" Faqat butun son kirita olasz !!!");
            //}
            //Main(args);


            ////9
            //Console.WriteLine(" Raqam kiriting: ");
            //string son=Console.ReadLine();  
            //bool isnumber=int.TryParse(son, out int value);
            //int soni = 0;
            //if (isnumber)
            //{
            //    for(int i = 1; i <= value; i++)
            //    {
            //        if (value % i == 0) soni++;
            //    }
            //    if (soni ==2)
            //    {
            //        Console.WriteLine($"{" Tub son: "}{value}");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Tub son emas ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Faqat butun son kirita olasiz !!!");
            //}
            //Main(args);

            ////10
            //Console.WriteLine(" raqam kiriting: ");
            //string son = Console.ReadLine();
            //bool isnumber = int.TryParse(son, out int number);
            //int raqam1 = 1, raqam2 = 0, yig=-1 ;
            //if (isnumber)
            //{
            //    for (int i = 0; i < number;i= i+1)
            //    {

            //        yig = raqam1 + raqam2;
            //        Console.Write($"{" "}{yig}");
            //        raqam1 = raqam2;
            //        raqam2 =   yig;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Faqat butun son kirita olasiz !!!");
            //}
            //Main(args);

        }
    }
}