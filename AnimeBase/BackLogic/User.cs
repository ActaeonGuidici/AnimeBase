using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeBase.BackLogic
{
    [Serializable]
    public class User : IOpenFiles
    {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Mail { get; set; }
            public User() { }

            public User(string login, string password, string mail)
            {
                Login = login;
                Password = password;
                Mail = mail;
            }

            public bool CheckLogin(string _login)
            {
                IOpenFiles openFiles = new User();
                List<User> users = openFiles.openUserFile();
                bool tmp = false;
                foreach (User user in users)
                {
                    if (user.Login == _login)
                    {
                        tmp = true;
                    }
                }
                return tmp;
            }
            public bool Log_In(string login, string password)
            {
                IOpenFiles openFiles = new User();
                List<User> users = openFiles.openUserFile();
                User tmpUser = new User();
                bool tmp = false;
                foreach (User user in users)
                {
                    if (login == user.Login && password == user.Password)
                    {
                        tmpUser = user;
                        tmp = true;
                    }
                }
                return tmp;
            }
            public void AddUser(User user)
            {
                IOpenFiles openFiles = new User();
                List<User> usersNew = openFiles.openUserFile();
                usersNew.Add(user);
                openFiles.saveToUserFile(usersNew);
            }
        }
    }
