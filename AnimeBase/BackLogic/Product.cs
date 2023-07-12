using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeBase.BackLogic
{
    [Serializable]
    public class Product : IOpenFiles
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product() { }
        public Product(string name, double price, int quantity, string description)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
        }
        public int LastNumber()
        {
            IOpenFiles openFiles = new Product();
            List<Product> productsNew = openFiles.openProductFile();
            int tmp = 0;
            foreach (Product product in productsNew)
            {
                tmp++;
            }
            return tmp++;
        }
        public void AddNewProduct(string _name, double _price, int _quantity, string _description)
        {
            IOpenFiles openFiles = new Product();
            List<Product> productsNew = openFiles.openProductFile();
            Product product = new Product(_name, _price, _quantity, _description);
            productsNew.Add(product);
            openFiles.saveToProductFile(productsNew);
        }
        public List<Product> OpenProductList()
        {
            IOpenFiles openFiles = new Product();
            List<Product> productsNew = openFiles.openProductFile();
            return productsNew;
        }
    }
}
