using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_12_Exceptions
{
    internal class User
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void SaveUser(string login, string password)
        {
            using (StreamWriter write = new StreamWriter("C:\\userList.txt", true))
            {
                write.WriteLine("Success, new user was added");
                write.WriteLine(login);
                write.WriteLine(password);
                write.Close();
                Console.WriteLine("Save successful");
            }
        }

        public bool Authorization(string login)
        {
            using (StreamReader read = new StreamReader("C:\\userList.txt"))
            {
                string buffer = read.ReadLine();
                Console.WriteLine("Put login");
                login = Console.ReadLine();
                while (buffer != null)
                {
                    if (buffer.Contains(login))
                    {
                        Console.WriteLine("Operation successful!");
                        return true;
                    }
                    Console.WriteLine("User not found");
                    return false;
                }
            }
            return true;
        }

            public void InputLogin(string Login)
            {
                if (Login.Length > 20)
                {
                    throw new WrongLoginException(Login, "Login must be shorter than 20 symbols");
                }
                else if (string.IsNullOrEmpty(Login))
                {
                    throw new WrongLoginException(Login, "Empty login");
                }
                else if (Login.Contains(" "))
                {
                    throw new WrongLoginException(Login, "Login include a space, or empty");
                }
            }
            public void InputPassword(string Password)
            {
                if (Password.Length > 20)
                {
                    throw new WrongLoginException(Password, "Password must be shorter than 20 symbols");
                }
                else if (string.IsNullOrEmpty(Password))
                {
                    throw new WrongLoginException(Password, "Empty password");
                }
                else if (Password.Contains(" "))
                {
                    throw new WrongLoginException(Password, "Password include a space or empty");
                }

                var check = ' ';
                foreach (var Number in Password)
                {
                    if (char.IsDigit(Number))
                    {
                        check = Number;
                    }
                }
                if (!char.IsDigit(check))
                {
                    throw new WrongPasswordException(Password, "Password must be include no less 1 number");
                }
            }



        }
    }
