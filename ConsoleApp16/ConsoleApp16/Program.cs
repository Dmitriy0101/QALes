using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
                     {
                 new User {Id=123412, Name="Dimon", Surname = "Dimovich", Price=10000},
                 new User {Id=123453, Name="Vladik", Surname = "Vladikovich", Price=9999},
                 new User {Id=123456, Name="Artem", Surname = "Artemovich", Price=8000},
                 new User {Id=123478, Name="Oleg", Surname = "Olefovich", Price=12000}
                    };
            var selectedUsers = from user in users
                                where user.Price < 10000
                                select user;
            foreach (User user in selectedUsers)
                Console.WriteLine($"{user.Name} - {user.Price}");
            Console.ReadKey();

        }

    }
}
