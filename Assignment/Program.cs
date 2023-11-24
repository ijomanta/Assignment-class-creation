using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new User("Uche", "Ijomanta", "email", "password");
            Console.WriteLine($"Full name: {user1.GetFullName()}");

            Console.WriteLine("First login: incorrect");
            Console.WriteLine(user1.Login("Email", "Password"));
            Console.WriteLine("\nSecond login: correct");
            Console.WriteLine(user1.Login("email", "password"));

        }
    }

    public interface IUser
    {
        public string FirstName { get; set; }
        public string LastName { set; get; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class User : IUser
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }

        public string Password { set; get; }

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string Login(string email, string password)
        {
            if (email == Email && password == Password)
            {
                return "login successful";
            }
            return "incorrect  credentials";

        }

    }

}