using accesmodifiernextday.Models;
using Microsoft.VisualBasic;

namespace accesmodifiernextday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company x000 = new Company(null);
            string Name=" ";
            string SurName=" ";
            string UserName;
            byte age=1;
            Employee x001=new Employee(Name,SurName,age);
            bool iscontinue = true;
            while(iscontinue)
                {
                
                Console.WriteLine($"Create a company: 0\nCreate an employee: 1\nDelete employee: 2\nUpdate employee: 3\nSee all employees: 4\nSee employee: 5\n End: 6");
                string a = Console.ReadLine();

               
                    
               
                switch (a)
                {
                    case "0":
                        Console.WriteLine("Company name:");
                        x000 = new Company(Console.ReadLine());
                        break;

                    case "1":
                        Console.WriteLine("Name: ");
                         Name = Console.ReadLine();
                        Console.WriteLine("SurName: ");
                         SurName = Console.ReadLine();
                        Console.WriteLine("Age: ");
                         age = Convert.ToByte(Console.ReadLine());
                        x001 = new Employee(Name, SurName, age);
                        x000.AddUser(x001);


                        break;

                    case "2":
                        Console.WriteLine("Write UserName");
                        UserName = Console.ReadLine();
                        x000.RemoveUser(x001.UserName);
                        break;
                    case "3":
                        Console.WriteLine("Write UserName");
                        UserName = Console.ReadLine();
                        x000.UpdateUser(x001.UserName);

                        break;
                    case "4":
                        x000.GetAllUsers();
                        break;
                    case "5":
                        Console.WriteLine("Write UserName");
                        UserName = Console.ReadLine();
                        x000.GetUser(x001.UserName);
                        break;
                    case "6":
                        iscontinue = false;
                        break;
                   

                }

            }
        }
        }
    }
