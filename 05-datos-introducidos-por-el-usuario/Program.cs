// See https://aka.ms/new-console-template for more information
using System;
class Variables
{
    static void Main()
    {

        int a = 4;
        int b = 6;

        System.Console.WriteLine("Dime el primer valor");
        a = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Dime el segundo valor");
        b = Convert.ToInt32(Console.ReadLine());

        int c = a + b;

        System.Console.WriteLine("Resultado: " + c);
    }
}
