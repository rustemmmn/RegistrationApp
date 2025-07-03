using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");

            while (true)
            {
                Console.WriteLine("Для регистрации введите '1', для входа введите '2'. Для выхода введите '3'.");

                char userInput = Console.ReadKey().KeyChar;
                if (userInput == '1')
                {
                    Console.WriteLine("\n\nВы выбрали регистрацию.");
                    CreateNewUser();
                }
                else if (userInput == '2')
                {
                    Console.WriteLine("\n\nВы выбрали вход.");
                    LogIn();
                }
                else if (userInput == '3')
                {
                    Console.WriteLine("\nВы выбрали выход.");
                    return;
                }
                else
                {
                    Console.WriteLine("\nНеверный ввод. Пожалуйста, попробуйте снова.");
                }
            }

        }

        public static void CreateNewUser() // Регистрация нового пользователя
        {
            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();

            Console.Write("Введите вашу почту: ");
            string userMail = Console.ReadLine();

            Console.Write("Введите логин: ");
            string userLogin = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string userPassword = Console.ReadLine();

            User user = new User(userName, userMail, userLogin, userPassword);
        }

        public static void LogIn() // Вход пользователя
        {
            Console.Write("Введите ваш логин: ");
            string userLogin = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string userPassword = Console.ReadLine();

            User currentUser = UsersStorage.GetUser(userLogin, userPassword);
            Console.WriteLine("\nВы успешно авторизировались!");
            Console.WriteLine("Данные вашего аккаунта: " +
                $"\nВаше имя: {currentUser.Name}" +
                $"\nВаш почта: {currentUser.Mail}" +
                $"\nВаш логин: {currentUser.Login}" +
                $"\nВаш текущий пароль: {currentUser.Password}\n");
        }

    }
}
