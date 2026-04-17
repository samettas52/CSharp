namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entity Framework --  it is kind of an ORM  -- object relational mapping

            //GetAll();

            int CategoryId;
            Console.WriteLine("Input the category id that you want");
            //the console readline will give us the output in  ASCII format  so we need to parse the output
            CategoryId=int.Parse(Console.ReadLine());
            GetProductByCategory(CategoryId);
        }

        private static void GetAll()
        {
            //we listed all products with linq 
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductByCategory(int categoryId)
        {  
            //we did get categoryId and we listed all product that who has this categoryId 
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var product in result)
            {
                Console.WriteLine("{0}---{1}",product.ProductName,product.CategoryId);
            }
        }
    }
}
