//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, I'm Paul, 18 years old");



//using System;

//namespace MyFirstProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        Console.WriteLine("My Name is Paul");
//        Console.Write("Hey");
//        Console.WriteLine("I'm 18 years old");
//        Console.Beep();

//            Console.ReadKey();

//        }
//    }
//}


using System;

namespace MyFirstProgram
{
    class Program

    {
        static void Main(string[] args)
        {
            int x, num;
            x = 20;
            

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (x > num)
            {
                Console.WriteLine("The number higher");
            } else if ( x < num)
            {
                Console.WriteLine("The nunber is lower");
               
            }
            else {
                Console.WriteLine("You got the corrrect answer!");
            }

            int a = 3;
            double b = Convert.ToDouble(a);

            Console.WriteLine(b.GetType());

            Console.ReadKey();
        }
    }
}