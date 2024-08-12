using System.Reflection.Metadata;
using TMS_12_Exceptions;

internal class Program
{
    private static void Main(string[] args, User user)
    {
        string Login = string.Empty;
        string Password = string.Empty;
        var User = new User(Login, Password);

        while (true)
        {
            Console.WriteLine("Registration form:" +
                "1. Login." +
                "2. Password" +
                "3. Authorization" +
                "4. Save" +
                "0. Exit");
            var choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Input login:");
                        Login = Console.ReadLine();
                        User.InputLogin(Login);
                    }
                    catch (WrongLoginException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Input password");
                        Password = Console.ReadLine();
                        User.InputPassword(Password);
                    }
                    catch (WrongPasswordException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        User.SaveUser(Login, Password);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "4":
                    try
                    {
                        User.Authorization(Login);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "0":
                default:
                    break;

            }
        }

    }
}