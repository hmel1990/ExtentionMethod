using System;
namespace ExtentionMethod
{
    //Вариант № 1 функция ничего не возвращает
    //public static class Extensions
    //{
    //    public static void Print(this string str)
    //    {
    //        Console.WriteLine(str);
    //    }

    //    public static void Print(this int number)
    //    {
    //        Console.WriteLine(number);
    //    }

    //    public static void Print(this double number)
    //    {
    //        Console.WriteLine(number);
    //    }
    //}
    //Вариант № 2 распечатается объект и вернется его копия 
    public static class Extensions2
    {
        public static string Print(this string str)
        {
            Console.WriteLine(str);
            //return str;
            return str.Replace(" ", "");
        }

        public static int Print(this int number)
        {
            Console.WriteLine(number);
            return number;
        }

        public static double Print(this double number)
        {
            Console.WriteLine(number);
            return number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            "Hello world".Print();
            2024.Print();
            0.08.Print();
        }
    }
}