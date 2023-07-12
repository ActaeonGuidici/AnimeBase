using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeBase.BackLogic
{
    [Serializable]
    public class Client : IOpenFiles
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public Client() { }
        public Client(string _name, string _surname, string _mail, string _phoneNumber, string _adress)
        {
            Name = _name;
            Surname = _surname;
            Mail = _mail;
            PhoneNumber = _phoneNumber;
            Adress = _adress;
        }

        public int LastNumber()
        {
            IOpenFiles openFiles = new Client();
            List<Client> clientsNew = openFiles.openClientFile();
            int tmp = 0;
            foreach (Client client in clientsNew)
            {
                tmp++;
            }
            return tmp++;
        }

        public void AddNewClient(string _name, string _surname, string _mail, string _phoneNumber, string _adress)
        {
            IOpenFiles openFiles = new Client();
            List<Client> clientsNew = openFiles.openClientFile();
            Client client = new Client(_name, _surname, _mail, _phoneNumber, _adress);
            clientsNew.Add(client);
            openFiles.saveToClientFile(clientsNew);
        }
        public List<Client> OpenClientList()
        {
            IOpenFiles openFiles = new Client();
            List<Client> clientsNew = openFiles.openClientFile();
            return clientsNew;
        }
    }
}
