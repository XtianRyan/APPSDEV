using System;
using System.ComponentModel.DataAnnotations;

namespace ACtivity2
{
    public class Profile
    {
        public string Name;
        public string Lname;
        public int Age;
        static void Main(string[] args)
        {
            List <Profile> list = new List<Profile>();

            while (true)
            {
                Console.WriteLine("Enter New Data [Y/N]");
                if (Console.ReadLine() == "N")
                {
                    break;
                }

                Profile person = new Profile();

                Console.WriteLine("Enter First Name");
                person.Name = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                person.Lname = Console.ReadLine();

                Console.WriteLine("Enter Age");
                person.Age = int.Parse(Console.ReadLine());

                list.Add(person);
            }
            list.ForEach(profile =>
            {
                Console.WriteLine(profile.Name);
                Console.WriteLine(profile.Lname);
                Console.WriteLine(profile.Age);
                Console.WriteLine("=====================");
            });

        }

    }
}
