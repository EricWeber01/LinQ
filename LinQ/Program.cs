using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };
            do
            {
                Console.WriteLine("Ex:");
                choose = Int32.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    var arr = values1.Concat(values2).Where(p => p > 10);
                    double avg = arr.Average();
                    foreach (var item in arr)
                        Console.Write(item + " | ");
                    Console.WriteLine("\n" + avg);
                }
                else if (choose == 2)
                {
                    var unique = values1.Concat(values2).Distinct();
                    foreach (var item in unique)
                        Console.Write(item + " | ");
                    Console.WriteLine("\n");
                }
                else if (choose == 3)
                {
                    var max = values1.Intersect(values2);
                    Console.WriteLine("Max " + max.Max());
                }
                else if (choose == 4)
                {
                    var sum = values1.Concat(values2).Where(v => v >= 5 && v <= 15).Sum();
                    Console.WriteLine("Sum " + sum);
                }
                else if (choose == 5)
                {
                    var sortable = values1.Concat(values2).OrderByDescending(v => v);
                    foreach (var item in sortable)
                        Console.Write(item + " | ");
                    Console.WriteLine("\n");
                }

            }
            while (choose != 0);
            List<Shop> shop1 = new List<Shop>
                    {
                        new Shop(){Id = 1, Title = "Nokia 1100", Price = 450.99, Category ="Mobile"},
                        new Shop(){ Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile"},
                        new Shop(){Id = 3, Title = "Refregirator 5000", Price = 2555, Category ="Kitchen"},
                        new Shop(){Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen"},
                        new Shop(){Id = 5, Title = "Magnitola", Price = 1499, Category = "Car"},
                    };
            List<Shop> shop2 = new List<Shop>
                    {
                        new Shop(){Id = 6, Title = "Samsung Galaxy", Price = 3100, Category ="Mobile"},
                        new Shop(){ Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
                        new Shop(){Id = 8, Title = "Owen", Price = 700, Category = "Kitchen"},
                        new Shop(){ Id = 9, Title = "Siemens Turbo", Price = 3199, Category ="Mobile"},
                        new Shop(){Id = 10, Title = "Lighter", Price = 150, Category = "Car"},
                    };
            do
            {
                Console.WriteLine("Ex:");
                choose = Int32.Parse(Console.ReadLine());
                if (choose == 1)
                {

                    var phones1000 = shop1.Concat(shop2).Where(p => p.Category == "Mobile" && p.Price > 1000);
                    foreach (var item in phones1000)
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (choose == 2)
                {
                    var nokitchen = shop1.Concat(shop2).Where(v => v.Price > 1000 && v.Category != "Kithcen").Select(v => v.Title + " | " + v.Price + "$");
                    foreach (var item in nokitchen)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choose == 3)
                {
                    var MaxPrice = shop1.Concat(shop2).OrderByDescending(p => p.Price).Select(p => p.Title + " | " + p.Category).First();
                    Console.WriteLine(MaxPrice);
                }
                else if (choose == 4)
                {
                    var Avg = shop1.Concat(shop2).Average(p => p.Price);
                    Console.WriteLine("Avg " + ((int)Avg) + "$");
                }
                else if (choose == 5)
                {
                    var Dist = shop1.Concat(shop2).Select(p => p.Category).Distinct();
                    foreach (var item in Dist)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choose == 6)
                {
                    var group = shop1.Concat(shop2).GroupBy(p => p.Price);

                    foreach (var item in group)
                    {
                        Console.WriteLine(item);
                        foreach (var val in item)
                            Console.WriteLine(val.Title);
                    }

                }
                else if (choose == 7)
                {
                    var abc = shop1.Concat(shop2).Select(p => p.Title + " | " + p.Category).OrderBy(v => v);
                    foreach (var item in abc)
                        Console.WriteLine(item);
                }
                else if (choose == 8)
                {
                    var cars = shop1.Concat(shop2).Where(p => p.Category == "Car").Any(p => p.Price > 1000 && p.Price < 2000);
                    Console.WriteLine(cars);

                }
                else if (choose == 9)
                {
                    var counter = shop1.Concat(shop2).Count(p => p.Category == "Car" || p.Category == "Mobile");
                    Console.WriteLine(counter);
                }
                else if (choose == 10)
                {
                    var cat = shop1.Concat(shop2).GroupBy(p => p.Category).Select(g => new { Name = g.Key, Count = g.Count() });
                    foreach (var item in cat)
                        Console.WriteLine(item.Name + ": " + item.Count);
                }
            } while (choose != 0);
        }
    }
}
