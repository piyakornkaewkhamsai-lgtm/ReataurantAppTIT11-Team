
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT1/1");

            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Tee noi", "Hot pot", 4.8),
                new Restaurant(5, "Lucky suki", "Hot pot", 4.9),
            };

            // A: Add Restaurant
            Console.WriteLine("\n=== Add Restaurant ===");

            Console.Write("Enter restaurant name: ");
            string name = Console.ReadLine();

            Console.Write("Enter restaurant type: ");
            string type = Console.ReadLine();

            Console.Write("Enter restaurant rating: ");
            double rate = double.Parse(Console.ReadLine());

            // สร้าง ID ใหม่
            int newId = restaurants.Count + 1;

            // เพิ่มร้านอาหารเข้า List
            Restaurant newRestaurant = new Restaurant(newId, name, type, rate);
            restaurants.Add(newRestaurant);

            Console.WriteLine("\nRestaurant added successfully!");

            // แสดงข้อมูลร้านอาหารทั้งหมด
            Console.WriteLine("\n=== Restaurant List ===");

            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Id}. {item.Name} ({item.type}) - Rating: {item.rate}");
            }

            // แสดงจำนวนร้านอาหาร
            var amount = restaurants.Count();

            // คำนวณคะแนนเฉลี่ย
            var avg = restaurants.Average(x => x.rate);

            Console.WriteLine("\nTotal is " + amount);
            Console.WriteLine("Average is " + avg);
        }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public double rate { get; set; }

        public Restaurant(int Id, string Name, string type, double rate)
        {
            this.Id = Id;
            this.Name = Name;
            this.type = type;
            this.rate = rate;
        }
    }
}
