using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Reload_Construction
{
    class Student
    {
        public Student(string lastName, DateTime birthday)//конструктор з 2 параметрами
        {
            _lastName = lastName;
            _birthday = birthday;
        }
        public Student(string lastName, string firstName, string middleName, DateTime birthday)//конструктор з 4 параметрами
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _birthday = birthday;

        }
        public Student(Student student)//конструктор з наслідуванням private полів класу Student
        {
            _lastName = student._lastName;
            _firstName = student._firstName;
            _middleName = student._middleName;
            _birthday = student._birthday;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }



        private string _lastName;
        private string _firstName;
        private string _middleName;
        private DateTime _birthday;



        public void Print()
        {
            Console.WriteLine("Name "+_firstName+"\nLast name "+_lastName+"\nMiddle name "+_middleName+"\nbirthday "+_birthday.ToString("MM.dd.yyyy")+"\n");
        }

    }
}
