using System;

namespace Inlämningsuppgifter4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal: ");
            string heltal = Console.ReadLine();
            string nyttHeltal = "";

            for (int i = 0; i < heltal.Length; i++)
            {
                char tecken = heltal[i];

                if (char.IsDigit(tecken))
                {
                    int siffra = (int)char.GetNumericValue(tecken);
                    siffra = (siffra + 1) % 10;
                    nyttHeltal += siffra;
                }
                else
                {
                    nyttHeltal += tecken;
                }
            }

            Console.WriteLine("Det nya talet är: " + nyttHeltal);
        }
    }

}
