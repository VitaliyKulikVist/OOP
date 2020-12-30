using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Modifical_Acess
{//ООП
 //Модификатори доступа

    //все що з типом доступу 
    //public    буде доступно в даному класі
    //private   НЕ буде доступно в даному класі
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            //point.x = 5;//якщо самі не зазначимо то отримаємо 0
            Console.WriteLine(point.x);


            point.PrintY();//хочь Y і private проте в звязку з тим що він описаний в методі який по собі public ми можемо вивести не як змінну а як метод

            Console.WriteLine("\n\n \t\t Викличемо метод який в середині класу забрав під своє 'крило' і public і private ");
            point.PrintPoint();



            Console.ReadKey();
        }
    }
}
