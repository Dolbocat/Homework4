using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dolbocat;
using System.IO;
namespace Homework4
{
    internal class Program
    {
        static void Main()
        {
            bool f = true;

            while (f)
            {
                Dolbocat.Utils.OutputHelpers.PrintInfo(4, "Тавризов Алексей");
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2, с использованием структуры");
                Console.WriteLine("3 -> Задача 2, с использованием файла");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================\n");

                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:

                        break;
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;

                    case 2:
                        StructInsert();
                        break;

                    case 3:
                        FailInsert();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;
                }
            }                      
           
             void StructInsert()
             {                
                Console.WriteLine("Задача номер 2");
                Console.WriteLine("=======================");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("ЛОГИН И ПАРОЛЬ");
                Console.WriteLine("Через структуру");

                int count = 3;
                var account = new Account();
                account.AccountLogin();

                var pass = new Account();
                pass.AccountPassword();
                do
                {
                    Console.Write("Введите логин: ");
                    string Login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string Password = Console.ReadLine();

                    if (account.AccountLogin(Login) && pass.AccountPassword(Password))
                    {
                        Console.WriteLine("Добро пожаловать в систему!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Логин или пароль введен не верно, попробуйте еще раз? осталось {count} попыток");
                        count--;
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Вы истратили попытки ввода и теперь забанены");
                    }
                }
                while (count > 0);
             }
             void FailInsert()
             {                    
                    Console.WriteLine("Задача номер 2");
                    Console.WriteLine("=======================");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("ЛОГИН И ПАРОЛЬ");
                    Console.WriteLine("Через файл");

                string[] lines = File.ReadAllLines("C:\\Users\\Dolbokot\\source\\repos\\Homework4\\LogPass.txt");
                    string login = lines[0];
                    string password = lines[1];
                    int count = 3;

                    do
                    {
                    Console.Write("Введите логин: ");
                    string Login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string Password = Console.ReadLine();

                    if (Account(Login, Password) == true)
                    {
                        Console.WriteLine("Добро пожаловать в систему!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Логин или пароль введен не верно, попробуйте еще раз? осталось {count} попыток");
                        count--;
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Вы истратили попытки ввода и теперь забанены");
                    }
                }
                while (count > 0);

                bool Account(string userLogin, string userPassword)
                {

                    if (userLogin == login && userPassword == password)
                        return true;
                    else
                        return false;
                }
                Console.Clear();
             }
        }        
    }
}


