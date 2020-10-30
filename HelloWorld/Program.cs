using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            //Console.ReadKey();
            //Console.WriteLine("Output text"); // output data in program console
            //Console.ReadKey(); // Waiting user press anykey.....
            Console.WriteLine("Hello user!");
            //Console.ReadKey();
            int x = 5;
            Console.WriteLine("Variable x is: ");
            Console.WriteLine(x);
            //Console.ReadKey();
            int a = 150 + 150;
            Console.WriteLine(a);
            // + , - , * , /
            string str = "some string";
            Console.WriteLine(str);

            string hello = "Hello";
            string world = "world!";
            Console.WriteLine(hello + world);
            const int A = 10;
            Console.WriteLine(A);

            // 1. int - type variable
            // 2. x - variable name
            // 3. 5 - Присваиваемое значение = ЛИТЕРАЛ

        }
    }
}
