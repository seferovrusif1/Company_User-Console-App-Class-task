using accesmodifiernextday.Models;
using Microsoft.VisualBasic;

namespace accesmodifiernextday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Company name:");
            Company x000 = new Company(Console.ReadLine());


            string Name;
            string SurName;
            byte age;
            Employee x001;

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine($"Create a company: 0\nDelete employee: 2\nUpdate employee: 3\nSee all employees: 4\nSee employee: 5\nadd employee: 6");
                string a = Console.ReadLine();

               
                    
               
                switch (a)
                {
                    case "0":
                        Console.WriteLine("Company name:");
                        Company x0000 = new Company(Console.ReadLine());
                        break;

                    case "1":
                        Console.WriteLine("Name: ");
                         Name = Console.ReadLine();
                        Console.WriteLine("SurName: ");
                         SurName = Console.ReadLine();
                        Console.WriteLine("Age: ");
                         age = Convert.ToByte(Console.ReadLine());
                        x001 = new Employee(Name, SurName, age);

                        break;

                    case "2":
                        x000.RemoveUser(x001.UserName);
                        break;
                    case "3":
                        x000.UpdateUser(x001.UserName);

                        break;
                    case "4":
                        x000.GetAllUsers();
                        break;
                    case "5":
                        x000.GetUser(x001.UserName);
                        break;
                    case "6":
                        x000.AddUser(x001);
                        break;

                }

            }
        }
        }
    }
