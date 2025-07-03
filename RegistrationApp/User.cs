using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public class User
    {
        /*
        private string userName;
        private string userMail;
        private string userLogin;
        private string userPassword;
        */

        public string Name { get; private set; }
        public string Mail { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string name, string mail, string login, string password)
        {
            Name = name;
            Mail = mail;
            Login = login;
            Password = password;

            UsersStorage.AddUser(this); // Добавление пользователя в хранилище
        }

    }
}
