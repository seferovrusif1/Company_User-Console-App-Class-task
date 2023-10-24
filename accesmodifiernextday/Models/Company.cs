using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesmodifiernextday.Models
{
    internal class Company
    {
        protected string _name;
        protected Employee[] _employees = new Employee[0]; 
        public string Name { get => _name; set { _name = char.ToUpper(value[0]) + value.Substring(1); ; } } 

        public Company(string Name)
        {
            _name = Name;
        }
        public void AddUser(Employee user)
        {
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = user;
            Console.WriteLine("\nUser Aded\n");
        }
        public void GetAllUsers()
        {
            foreach (var item in _employees)
            {
                Console.WriteLine(item.UserName);
            }
        }
        public void GetUser(string username)
        {
            foreach (var item in _employees)
            {
                if (item.UserName == username) 
                {
                    Console.WriteLine($"\n\nEmploye name: {item.Name}\nSurname: {item.SurName}\nAge: {item.Agee}\nUsername: {item.UserName}\n\n");
                }
            }
        }
        public void RemoveUser(string username)
        {
            foreach (var item in _employees)
            {
                if (item.UserName == username)
                {
                    Employee[] _employeesTemp = new Employee[_employees.Length - 1];
                    for (int i = 0; i < _employees.Length; i++)
                    {
                        if (_employees[i].UserName != username)
                        {
                            _employeesTemp[i] = _employees[i];
                        }
                    }
                    _employees = _employeesTemp;
                    Console.WriteLine("\nUser Removed\n");
                }
                else
                {
                    Console.WriteLine("User is not found");
                }
            }
        }
        public void UpdateUser(string username)
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].UserName == username)
                {
                    Console.WriteLine("1.Update Name 2.Update Surname 3.Update Age");
                    string d = Console.ReadLine();
                    switch (d)
                    {
                        case "1":
                            UpdateName(i);
                            break;
                        case "2":
                            UpdateSurName(i);
                            break;
                        case "3":
                            UpdateAge(i);
                            break;
                    }
                }
            }
        }
        public void UpdateName(int i)
        {
            _employees[i].Name = Console.ReadLine();
            _employees[i].UserName= _employees[i].Name + "_" + _employees[i].SurName;
            Console.WriteLine("\nName and UserName updated\n");
        }
        public void UpdateSurName(int i)
        {
            _employees[i].SurName = Console.ReadLine();
            _employees[i].UserName = _employees[i].Name + "_" + _employees[i].SurName;
            Console.WriteLine("\nSurName and UserName updated\n");

        }
        public void UpdateAge(int i)
        {
            _employees[i].Agee = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\nAge updated\n");

        }

    }
}
