using System;
namespace Set1Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti 3 numere: ");
            string[] numere = Console.ReadLine().Split(" ");
            int num1 = int.Parse(numere[0]);
            int num2 = int.Parse(numere[1]);
            int num3 = int.Parse(numere[2]);

            if (num1 > num2)
            {
                (num1, num2) = (num2, num1);
            }
            else if (num1 > num3)
            {
                (num1, num3) = (num3, num1);
            }
            else if (num2 > num3)
            {
                (num2, num3) = (num3, num2);

            }
            else
            {
                Console.WriteLine("Ceva nu a functionat");
            }

                Console.WriteLine($"Ordinea este {num1}, {num2}, {num3}");
        }
    }
}
