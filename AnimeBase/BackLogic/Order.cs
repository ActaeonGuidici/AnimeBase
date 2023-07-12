using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeBase.BackLogic
{
    [Serializable]
    public class Order : IOpenFiles
    {
        public Client Client { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateOnly Date { get; set; }

        public Order() { }
        public Order(Client client, Product product, int quantity, DateOnly date)
        {
            Client = client;
            Product = product;
            Quantity = quantity;
            Date = date;
        }
        public int LastNumber()
        {
            IOpenFiles openFiles = new Order();
            List<Order> ordersNew = openFiles.openOrderFile();
            int tmp = 0;
            foreach (Order order in ordersNew)
            {
                tmp++;
            }
            return tmp++;
        }
        public void AddNewProduct(Client _client, Product _product, int _quantity, DateOnly _date)
        {
            IOpenFiles openFiles = new Order();
            List<Order> ordersNew = openFiles.openOrderFile();
            Order order = new Order(_client, _product, _quantity, _date);
            ordersNew.Add(order);
            openFiles.saveToOrderFile(ordersNew);
        }
        public List<Order> OpenOrderList()
        {
            IOpenFiles openFiles = new Order();
            List<Order> ordersNew = openFiles.openOrderFile();
            return ordersNew;
        }
    }
}
