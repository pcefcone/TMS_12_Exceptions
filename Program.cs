using System.Diagnostics;
using System.Reflection.Metadata;
using TMS_12_Exceptions;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader sr = new StreamReader("D:\\userList.txt");
            StreamWriter sw = new StreamWriter("C:\\Test.txt");
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }


        string Login = string.Empty;
        string Password = string.Empty;
        var user = new User(Login, Password);



        while (true)
        {
            Console.WriteLine("Registration form:" +
                "\n1. Login." +
                "\n2. Password" +
                "\n3. Save" +
                "\n4. Authorization" +
                "\n0. Exit");
            var choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Input login:");
                        Login = Console.ReadLine();
                        user.InputLogin(Login);
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
                        user.InputPassword(Password);
                    }
                    catch (WrongPasswordException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        
                        user.Authorization(Login);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "4":
                    try
                    {
                        user.SaveUser(Login, Password);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                    case "0":
                    Console.WriteLine("Good bye!");
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
        }

    }
}