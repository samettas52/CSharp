using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{

    //Methods = they are used to perform specific actions or operations on the data.
    //In this case, the Add method is used to add a product to the system.
    //It takes a Product object as a parameter and performs the necessary actions to add that product,
    //such as saving it to a database or displaying a message.

    //Reusability = we can use the same method in different parts of the application without having to rewrite the code.
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi: " + product.ProductName);
        }
    }
}
