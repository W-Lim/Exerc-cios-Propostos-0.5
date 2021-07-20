using System;
using System.Collections.Generic;
using System.Globalization;
using AtvMetAbstratos.Entities;

namespace AtvMetAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data: ");
                Console.Write("Individual or company (i/c)? ");
                string op = Console.ReadLine();
                
                if (op == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double aincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expeditures: ");
                    double hexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, aincome, hexpenditures));

                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double aincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, aincome, number));

                }
            }

            double sum = 0.0;
            foreach(TaxPayer tp in list)
            {
                sum += tp.Tax();
            }

            Console.WriteLine(  );
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer tp in list)
            {
                Console.WriteLine(tp.TaxPride());

            }

            Console.WriteLine(  );
            Console.WriteLine("Total TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
           

        }
    }
}
