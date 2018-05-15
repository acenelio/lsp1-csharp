using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using Course.Services;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<Person> list = new List<Person>();

            Console.Write("How many people? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter data for person #{i}:");
                Console.Write("Elderly (y/n)? ");
                string elderly = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Amount: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (elderly == "y") {
                    list.Add(new ElderlyPerson() { Name = name, Amount = amount });
                }                
                else {
                    list.Add(new OrdinaryPerson() { Name = name, Amount = amount });
                }
            }

            CalculationService calculationService = new CalculationService();
            double total = calculationService.TotalBonus(list);

            Console.WriteLine("Total bonus = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
