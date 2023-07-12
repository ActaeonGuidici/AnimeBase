using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AnimeBase.BackLogic
{
    public interface IOpenFiles
    {
        public List<User> openUserFile()
        {
            List<User> usersNew = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("UsersData.xml", FileMode.OpenOrCreate))
            {
                usersNew = xmlSerializer.Deserialize(fs) as List<User>;
            }
            return usersNew;
        }
        public void saveToUserFile(List<User> usersNew)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("UsersData.xml", FileMode.Open))
            {
                formatter.Serialize(fs, usersNew);
            }
        }
        public List<Client> openClientFile()
        {
            List<Client> clientsNew = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Client>));
            using (FileStream fs = new FileStream("ClientsData.xml", FileMode.OpenOrCreate))
            {
                clientsNew = xmlSerializer.Deserialize(fs) as List<Client>;
            }
            return clientsNew;
        }
        public void saveToClientFile(List<Client> clientsNew)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Client>));
            using (FileStream fs = new FileStream("ClientsData.xml", FileMode.Open))
            {
                formatter.Serialize(fs, clientsNew);
            }
        }
        public List<Product> openProductFile()
        {
            List<Product> productsNew = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream("ProductsData.xml", FileMode.OpenOrCreate))
            {
                productsNew = xmlSerializer.Deserialize(fs) as List<Product>;
            }
            return productsNew;
        }
        public void saveToProductFile(List<Product> productsNew)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream("ProductsData.xml", FileMode.Open))
            {
                formatter.Serialize(fs, productsNew);
            }
        }
        public List<Order> openOrderFile()
        {
            List<Order> ordersNew = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("OrdersData.xml", FileMode.OpenOrCreate))
            {
                ordersNew = xmlSerializer.Deserialize(fs) as List<Order>;
            }
            return ordersNew;
        }
        public void saveToOrderFile(List<Order> ordersNew)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("OrdersData.xml", FileMode.Open))
            {
                formatter.Serialize(fs, ordersNew);
            }
        }
    }
}
