using System;

namespace Copy_Constructors
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int result1, result2, result3, result4;
            Fraction fraction1 = new Fraction();
            fraction1.Numerator = 10;
            fraction1.Denominator = 2;

            Fraction fraction2 = new Fraction(fraction1);

            result1 = fraction2.Numerator / fraction2.Denominator;
            result2 = fraction2.Numerator * fraction2.Denominator;
            result3 = fraction2.Numerator + fraction2.Denominator;
            result4 = fraction2.Numerator - fraction2.Denominator;

            Console.WriteLine(fraction2.Numerator + "/" + fraction2.Denominator);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);


            // Tema: de gasit o modalitate pentru a afisa rezultatul (o metoda sau o variabila noua).
        }
    }
}
