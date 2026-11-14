
using System;
using System.Collections.Generic;
using System.Linq;

namespace restaurantApp1
{
    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
            new Restaurant(4, "Tee noi", "Hot pot", 4.8),
            new Restaurant(5, "Lucky suki", "Hot pot", 4.9)
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;

                    case "2":
                        ShowGoodRating();
                        break;

                    case "3":
                        ShowSummary();
                        break;

                    case "0":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.Write("กรอกชื่อร้าน: ");
            string name = Console.ReadLine();

            Console.Write("กรอกประเภทอาหาร: ");
            string type = Console.ReadLine();

            Console.Write("กรอกคะแนน (เช่น 4.5): ");
            double rating = Convert.ToDouble(Console.ReadLine());

            int id = restaurants.Count == 0
                ? 1
                : restaurants.Max(r => r.Id) + 1;

            restaurants.Add(new Restaurant(id, name, type, rating));

            Console.WriteLine("เพิ่มร้านเรียบร้อยแล้ว!");
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("\n===== Good Rating Restaurants =====");

            var goodRestaurants = restaurants
                .Where(r => r.Rating >= 4.5)
                .ToList();

            if (goodRestaurants.Count == 0)
            {
                Console.WriteLine("ไม่พบร้านที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป");
                return;
            }

            foreach (var r in goodRestaurants)
            {
                Console.WriteLine($"ชื่อร้าน: {r.Name}");
                Console.WriteLine($"ประเภทอาหาร: {r.Type}");
                Console.WriteLine($"คะแนน: {r.Rating}");
                Console.WriteLine("--------------------");
            }
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            if (restaurants.Count == 0)
            {
                Console.WriteLine("ยังไม่มีข้อมูลร้านอาหาร");
                return;
            }

            var sortedList = restaurants
                .OrderByDescending(x => x.Rating)
                .ToList();

            Console.WriteLine("\n=== รายชื่อร้านอาหารทั้งหมด ===");

            int a = 1;

            foreach (Restaurant item in sortedList)
            {
                Console.WriteLine($"{a}. {item.Name} Rate: {item.Rating}");
                a++;
            }

            double maxRating = sortedList.Max(x => x.Rating);
            double minRating = sortedList.Min(x => x.Rating);
            double avgRating = restaurants.Average(x => x.Rating);

            Console.WriteLine("\n--- สรุป ---");

            foreach (var r in sortedList.Where(x => x.Rating == maxRating))
            {
                Console.WriteLine($"ร้านที่มีคะแนนสูงสุด: {r.Name} Rate: {r.Rating}");
            }

            if (minRating < maxRating)
            {
                foreach (var r in sortedList.Where(x => x.Rating == minRating))
                {
                    Console.WriteLine($"ร้านที่มีคะแนนต่ำสุด: {r.Name} Rate: {r.Rating}");
                }
            }

            Console.WriteLine($"จำนวนร้านทั้งหมด: {restaurants.Count}");
            Console.WriteLine($"คะแนนเฉลี่ย: {avgRating:F2}");
        }
    }

    // Class Restaurant
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id, string name, string type, double rating)
        {
            Id = id;
            Name = name;
            Type = type;
            Rating = rating;
        }
    }
}
