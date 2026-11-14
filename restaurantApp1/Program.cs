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
            Console.WriteLine("=== รายชื่อร้านอาหาร ===");
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Id}. {item.Name} ({item.type}) - Rating: {item.rate}");
            }

            Console.WriteLine("========================================================================");
            int totalrestaurant = restaurants.Count;
            double totalrating = restaurants.Average(r => r.rate);
            Console.WriteLine($"จำนวนร้านอาหารทั้งหมด {totalrestaurant}ร้าน");
            Console.WriteLine($"คะแนนเฉลี่ยรวม{totalrating:F2} คะแนน");
            Console.WriteLine("========================================================================");


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

    
    
        