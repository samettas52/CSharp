namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //we occurred the category list 
            List<Category> categories = new List<Category>
            {
                new Category {CategoryId=1,CategoryName= "Computer"},
                new Category {CategoryId=2,CategoryName="Phone"}
            };
            //we occurred the Product list
            List<Product> products = new List<Product>
            {
                new Product { ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitsInStock=5 },
                new Product { ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=8000,UnitsInStock=3 },
                new Product { ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=6000,UnitsInStock=2 },
                new Product { ProductId=4,CategoryId=2,ProductName="Samsung Phone",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitsInStock=15 },
                new Product { ProductId=5,CategoryId=2,ProductName="Apple Phone",QuantityPerUnit="4 GB RAM",UnitPrice=8000,UnitsInStock=0 }
            };
            //we used extract method 

            //test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTestWithWhere(products);

            //ClassicLinqTest(products);

            //JoinTest(categories, products);
        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            // we did join the categories proprties in products . we connect them with categoryid
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice, CategoryName = c.CategoryName };
            foreach (var productDto in result)
            {
                //Console.WriteLine(productDto.CategoryName+" <---> "+productDto.ProductName);
                //the other way for writing
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            //the other way the writing linq
            var result = from p in products
                         where p.UnitPrice > 6000 && p.CategoryId == 1
                         orderby p.UnitPrice descending, p.ProductName ascending
                         //normally we were add property in foreach but we can select in this structure
                         //select p.ProductName;
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
        }

        //we use single line query for all of them
        private static void AscDescTestWithWhere(List<Product> products)
        {
            //we made a contains example for where
            //This is giving us the ordered by database but we can change this . we can add the filter .
            //if the values are equal . orderby(orderbydescending to) will order them database's order
            //if we want to control of equal values order than we can use thanby.
            //thenby order them by alphabet
            //descending big => small sort , default small =>big sort
            var result = products.Where(p => p.ProductName.Contains("one")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            //findall getting list 
            //contains for the specific searching we can also use in where
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindTest(List<Product> products)
        {
            //giving us the object that we look 
            var result = products.Find(p => p.ProductId == 1);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            //searching the items from list or array and give us the bool result
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void test(List<Product> products)
        {
            Console.WriteLine("----------------------- Algorithmic -----------------------");
            //show on the console products
            foreach (var product in products)
            {
                //filtering example without linq
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                { Console.WriteLine(product.ProductName); }
            }

            Console.WriteLine("----------------------- Linq -----------------------");
            //we used the p for product in products(predicate)
            //we made the filtering with linq 
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //without the linq
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                { filteredProducts.Add(product); }

            }
            return filteredProducts;
        }
        //with the linq
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    }
    //when we don't need the all properties, when we look special properties than  we create this dto structure
    // dto = data tranformation object 
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    //we create a product class
    //we add categoryid in product class because we are matching category and product (the sub class is product)
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    //we create a category class
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
