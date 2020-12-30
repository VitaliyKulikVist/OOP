using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   //ООП
    //Клас
    //Обект класа
        enum Color// Як і фун KEY дає змогу вибирати з варіантів
    {
        red,
        green,
        yellow,
        blue,
        orange
    }
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.id = Guid.NewGuid();
            student.firstName = "Vitaliy";
            student.lastName = "Kulik";
            student.middleName = "Olexiyovich";
            student.age = 23;
            student.group = "PM";
            return student;
        }
        static void Print (Student student)
        {
            Console.WriteLine("Information about a Student:");
            Console.WriteLine("ID:\t\t" + student.id);
            Console.WriteLine("firstName:\t" + student.firstName);
            Console.WriteLine("lastName:\t" + student.lastName);
            Console.WriteLine("middleName:\t" + student.middleName);
            Console.WriteLine("age:\t\t" + student.age);
            Console.WriteLine("group:\t\t" + student.group);
        }



        static void Main(string[] args)
        {
            ///////////////////////////////////////////Point//////////////////////////////
            Point name_Point1 =new Point();//create new Class point1              exepliar classa
            name_Point1.x = 4;
            name_Point1.y = 2;
            Console.WriteLine(name_Point1.x +"\t"+ name_Point1.y);
            Console.WriteLine();
            Point name_Point2 = new Point();//create new Class point2              exepliar classa
            name_Point2.x = 2;//Назначение значений "обекта класса" по примеру екземпляра класа name_Point2 
            name_Point2.y = 6;
            Console.WriteLine(name_Point2.x + "\t" + name_Point2.y);


            //////////////////////////////////////////Point_null//////////////////////////////
            Point_null name_Point_null = new Point_null();
            name_Point_null = null;//Розрив звязку з даними які в екземплярі класу
            //name_Point_null.x = 1;//не можемо щось назначити після обнулення...
            //name_Point_null.y = 2;


            //////////////////////////////////////////Point_Color//////////////////////////////
            Point_Color name_Point_Color = new Point_Color();
            name_Point_Color.color = Color.orange;//присвоюемо значення кольору обекту Color
            Console.WriteLine("Color is:\t"+name_Point_Color.color);


            //////////////////////////////////////////Metod Class Point//////////////////////////////
            //////////////////////////////////////Наслідування методів класу/////////////////////////
            //name_Point1.Equals();
            name_Point1.GetHashCode();
            name_Point1.GetType();
            name_Point1.ToString();
            Console.WriteLine("GetHashCode:\t " + name_Point1.GetHashCode());
            Console.WriteLine("GetType:\t " + name_Point1.GetType());
            Console.WriteLine("ToString:\t " + name_Point1.ToString());
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n\n");
            /////////////////////////////////////////////Параметри класу Student////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var firstStudent = GetStudent();// var змінна firstStudent присвоїти все з методу GetStudent
            Print(firstStudent);//Викликаємо метод Print який поверне значення firstStudent в середині з (Student student)





            Console.ReadKey();
        }
    }
}
