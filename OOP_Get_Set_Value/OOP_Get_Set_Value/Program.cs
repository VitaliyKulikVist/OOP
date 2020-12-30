using System;

namespace OOP_Get_Set_Value
{
    class Program
    {//ООП
        //Властивості(свойства) Properties             instrument of     Encapsulation
        static void Main(string[] args)
        {
            int z1;
            Console.WriteLine("Присвоєння значення полю Х: ");
            Point point = new Point();
            z1= Convert.ToInt32(Console.ReadLine());//записуємо значення з клавіатури в змінну z1(не задумуємось чи це гетер чи сетер в середині воно собі знає)
            point.SetX(z1);//Змінну z1 передаємо в метод SetX       там відбудуться порівняння
            point.Print();//Виводимо після порівнянь значення

            Console.WriteLine("Присвоєння значення полю Y: ");
            point.Y_set_get = Convert.ToInt32(Console.ReadLine());//записуємо значення з клавіатури  в метод Y_set_get
            int y = point.Y_set_get;//Отримуємо після аналізу значення і заносимо в змінну у
            point.Print();//Виводимо після порівнянь значення

            Console.WriteLine("Присвоєння значення полю Z: ");
            point.Z_get_set = Convert.ToInt32(Console.ReadLine());
            int z = point.Z_get_set;
            point.Print();

            Console.ReadKey();
        }
    }
}
