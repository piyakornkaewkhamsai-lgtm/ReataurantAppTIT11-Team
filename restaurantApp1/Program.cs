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
    




