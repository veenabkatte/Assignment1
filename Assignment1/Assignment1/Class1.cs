using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter the age");
            String result = Console.ReadLine();
            int age;
            bool num = int.TryParse(result,out age);
            if (num)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
       
        Console.ReadLine();

        }
    }
}
