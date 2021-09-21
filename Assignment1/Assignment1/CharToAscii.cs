using System;

namespace Assignment1
{
    class CharToAscii
    {
        static void Main(string[] args)
        {
            //Char a = 'A';
            Console.WriteLine("enter the chater");
            Char a = Convert.ToChar(Console.ReadLine());
            int asciiCode = (int)a;
            Console.WriteLine(asciiCode);
            Console.ReadLine();

        }
    }
}
