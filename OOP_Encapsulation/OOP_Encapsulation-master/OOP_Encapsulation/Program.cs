using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation
{//ООП
    //////////////////////////////////////////////////////////////////////////////Encapsulation//////////////////////////////////////////////////////////////////
    ///Дає змогу написати клас так, щоб його можна було використовувати так як я задумав (оптимізація коду, зменшення кількості багів)
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();//оскільки лише цей метод є Публічним, ми можемо лише вистрелити

           
            Console.WriteLine("\n\nAuto Shoots 20 bullet");

            Console.ReadKey();
            for (int i=0;i<20;i++)
            {
                gun.Shoot();
            }

            Console.ReadKey();
        }
    }
}
