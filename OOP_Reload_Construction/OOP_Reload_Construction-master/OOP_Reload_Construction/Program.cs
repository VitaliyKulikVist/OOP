using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Reload_Construction
{//ООП
    //перегрузка конструктора класса(+- те саме що перегрузка методів)
    //Ізначально при створенні класу створюється дефолтний конструктор, але якщо ми створюємо свій то дефолтний пропадає і на його місце стає наш
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2,4);//це ми вибрали конструктор з параметрами
            Point point2 = new Point();//Це ми вибрали конструктор без параметрів
            Console.Write("Конструктор з параметрами 2 4:");
            point.Print();
            Console.Write("Конструктор без параметрів але х=у=1:");
            point2.Print();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////Student//////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Student student1 = new Student("Kulik",new DateTime(1997,02,05));
            Console.WriteLine("\n\n\n Constructor STUDENT 2 parametra:");
            student1.Print();




            Console.WriteLine("\n\n\n Constructor STUDENT 4 parametra:");
            Student student2 = new Student("Kulik", "Vitaliy","Alexeevich", new DateTime(1997, 02, 05));
            student2.Print();

            Console.WriteLine("\n\n\n Constructor STUDENT 1 parameter:");
            //Student student3 = student1;//маємо дві силки які зсилаються на одні і ті самі данні. Іншими словами переназначивши ми отримаємо 2 ідентичні методи класу студент
            Student student3 =new Student(student1);//користуємось конструктором створення нового класу щоб не було не порозумінь із за переприсвоєння даних
            student1.SetLastName("Zibrov");
            student3.Print();






            Console.ReadKey();
        }
    }
}
