namespace MyProjectASPNETCORE.Models
{
    public class Repo
    {
        public static List<Product> myproducts=new List<Product>();
        public static IEnumerable<Product> products  { get{ return myproducts; } }
        public static void AddProduct()
        {
            Product product1 = new Product { Name="Car",Price=678.90M};
            Product product2 = new Product { Name = "Boat", Price = 567 };

            myproducts.Add(product1);
            myproducts.Add(product2);

        }
    }
}
