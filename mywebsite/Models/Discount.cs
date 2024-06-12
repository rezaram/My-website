namespace mywebsite.Models
{
    //is here somethings code...

    public class Discount
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string off { get; set; }

        public Discount(int id, string name, string image, int price, string off)
        {
            this.id = id;
            Name = name;
            Image = image;
            Price = price;
            this.off = off;
        }
    }
}


