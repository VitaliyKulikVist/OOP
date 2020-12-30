using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Metod_Class
{//в середині класу, створені методи можна визивати без поселань а напряму(но це у випадку Паблік метода)
    class Student//Даний клас залежить від класса Console тому як в ньому в середині є метод який використовує цей метод(нарушення СОЛІД)
    {
        public Guid id;//type for @ID@
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()//якщо метод в середині класу і ми його ж і використовуємо, параметри вказувати не обовязково
        {
            Console.WriteLine("Information about a Student:");
            Console.WriteLine("ID:\t\t" + id);
            Console.WriteLine("firstName:\t" + firstName);
            Console.WriteLine("lastName:\t" + lastName);
            Console.WriteLine("middleName:\t" + middleName);
            Console.WriteLine("age:\t\t" + age);
            Console.WriteLine("group:\t\t" + group);
        }

        public string GetFullName()
        {
            return "Student is: \t\t" + firstName + lastName + middleName;
        }
    }
}
