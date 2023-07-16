namespace MyProjectASPNETCORE.Models
{
    public class Repo
    {
        public static List<SharedTask> myproducts=new List<SharedTask>();
        public static IEnumerable<SharedTask> products  { get{ return myproducts; } }
        public static void AddProduct(SharedTask shared)
        {
            myproducts.Add(shared);

        }
    }
}
