using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Для регистрации введите '1', для входа введите '2'. Для выхода введите '3'.");

            while (true)
            {
                char userInput = Console.ReadKey().KeyChar;
                if (userInput == '1')
                {
                    Console.WriteLine("\nВы выбрали регистрацию.");
                    Console.Write("Введите ваше имя: ");
                    string userName = Console.ReadLine();
                    Console.Write("Введите логин: ");
                    string userLogin = Console.ReadLine();
                    Console.Write("Введите вашу почту: ");
                    string userMail = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string userPassword = Console.ReadLine();
                    User user = new User(userName, userMail, userLogin, userPassword);

                }
                else if (userInput == '2')
                {
                    Console.WriteLine("\nВы выбрали вход.");
                    // Здесь можно добавить логику входа
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
    }
}
