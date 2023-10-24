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
                if (item.UserName == username) ;
                {
                    Console.WriteLine(item.GetFullInfo);
                }
            }
        }
        public void RemoveUser(string username)
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].UserName == username)
                {
                    _employees[i] = null;          
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
        }
        public void UpdateSurName(int i)
        {
            _employees[i].SurName = Console.ReadLine();
        }
        public void UpdateAge(int i)
        {
            _employees[i].Agee = Convert.ToByte(Console.ReadLine());
        }

    }
}
