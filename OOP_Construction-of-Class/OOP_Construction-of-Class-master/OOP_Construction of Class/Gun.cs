using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Construction_of_Class
{
    class Gun
    {
        //В візуал студії конструктор можна створити написавши ctor і нажати 2 рази Tab

        public Gun()//обумовлення конструктора з доступом public (якщо змінити то не визвемо в інших класах а лише в цьому) private якщо патерн Singleton
        {
            
            //isloaded = true;//всі екземпляри класу Gun будуть в заряженому вигляді створюватись
            //isloaded = false;//всі екземпляри класу Gun будуть в РОЗряженому вигляді створюватись
            Reloaded();//можемо відразу запускати процес перезарядки            створюємо відразу заряжену пушку
        }


        private bool isloaded;//стан класу Gun

        private void Reloaded()
        {
            Console.WriteLine("Reloaded....");
            isloaded = true;
            Console.WriteLine("Reload Complete....");
        }

        public void Shoot()
        {
            if (!isloaded)
            {
                Console.WriteLine("Weapon can`t shoot....");
                Reloaded();
            }
            Console.WriteLine("BaH!\n");
            isloaded = false;
        }
    }
}
