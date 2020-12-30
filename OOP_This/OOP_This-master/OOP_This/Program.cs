using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_This
{//ооп
    //THIS
    //Дає можливість отримати доступ до наявного екземпляру класу               але будучи в середині цсього класу
    //використовується коли є якась неоднозначність в назвах змінних 
    class Program
    {
        static void Main(string[] args)//в методах з модифікатором static використовувати THIS не можна(бо THIS забеспечує доступ до ЛИШЕ цього класу
        {
            Student student1 = new Student("Vitaliy", new DateTime(1997,05,02));
            student1.Print();
            Student student2 = new Student("Zinoviy", new DateTime(1997, 05, 02));
            student2.Print();

          
            Console.ReadKey();
        }
    }
}
