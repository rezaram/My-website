using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace mywebsite.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }

        public Product(int id, string name, string image, int price)
        {
            this.id = id;
            Name = name;
            Image = image;
            Price = price;
        }
    }
}


