using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_This
{//this може отримати доступ і до private полів але лише які в межах цього класу
    class Student
    {
        public Student(string lastName, DateTime birthday)//конструктор з 2 параметрами
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }
        public Student(string lastName, string firstName, string middleName, DateTime birthday):this(lastName, birthday)//пепредаємо частину коду з попереднього 
            //конструктора, таким чином дівілігіруємо обробку 2 параметрів lastName та birthday на інший конструктор
        {   //оскільки в цьому конструкторі ми не прописали lastName і birthday но в параметрах вказані то перейде обробка даних на попередній конструктор
            //де ці данні є
            this.firstName = firstName;
            this.middleName = middleName;
        }
        public Student(Student student)//конструктор з наслідуванням private полів класу Student
        {
            this.lastName = student.lastName;
            this.firstName = student.firstName;
            this.middleName = student.middleName;
            this.birthday = student.birthday;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }



        private string lastName;
        private string firstName;
        private string middleName;
        private DateTime birthday;



        public void Print()
        {
            Console.WriteLine("Name " + firstName + "\nLast name " + lastName + "\nMiddle name " + middleName + "\nbirthday " + birthday.ToString("MM.dd.yyyy") + "\n");
        }
    }
}
