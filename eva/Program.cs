using System;

namespace eva
{
    class Program
    {
        static void Main(string[] args)
        {
            billetera Billetera = new billetera();
            Billetera.ingrese(95000);
            Console.WriteLine($"El dinero de su cuenta es de {Billetera}");
            Console.ReadLine();
        }
    }
}
