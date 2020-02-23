using System;

namespace FunkcjaKwadratowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 2, B = 3, C = -2;
           
            Console.WriteLine("Parametry równania:\n");
            Console.WriteLine("A = " + A + " B = " + B + " C = " + C + "\n");

            if (A == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe, gdyż A = 0!!!");
            }
            else
            {
                double delta = (B * B) - 4 * A * C;

                if (delta <0)
                {
                    Console.WriteLine("Delta < 0.");
                    Console.WriteLine("To równianie nie ma rozwiązania w zbiorze liczb rzeczywistych.");
                }
                else if(delta == 0)
                {
                    double wynik = -B / (2 * A);
                    Console.WriteLine("Rozwiązanie: x = " + wynik);

                }
                else
                {
                    double wynik;
                    wynik = (-B + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("Rozwiązanie: x1 = " + wynik);
                    wynik = (-B - Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("x2 = " + wynik);
                }
            }
        }
    }
}
