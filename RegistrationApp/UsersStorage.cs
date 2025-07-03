using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public static class UsersStorage
    {
        static List<User> users = new List<User>();

        public static void AddUser(User user) // Метод для добавления нового пользователя в хранилище
        {

            if (user.Name != null && user.Mail != null && user.Login != null && user.Password != null)
            {
                // Проверка совпадения логина или почты и пароля
                if (users.Any(u => (u.Login == user.Login || u.Mail == user.Mail)))
                {
                    Console.WriteLine("Пользователь с данным логином или паролем уже зарегестрирован.");
                    return;
                }
                else
                {
                    users.Add(user);
                    Console.WriteLine("Вы успешно зарегестрировались!\n");
                }

            }
        }

        public static User GetUser(string login, string password) // Метод для получения пользователя по логину и паролю
        {

            return users.FirstOrDefault(u => u.Login == login && u.Password == password);

        }

    }
}
