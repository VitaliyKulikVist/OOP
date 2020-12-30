using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Construction_of_Class
{
    class Gun2
    {
        public Gun2(bool isloaded)//передаємо параметри, тоді при створені обєкта треба буде вказувати: Хочемо Заряжену пушку чи НЕ заряжену
        {
            //this.isloaded = isloaded;//щоб показати яку змінну присвоємо а яку використовуємо
            _isloaded = isloaded;
        }


        private bool _isloaded;//стан класу Gun

        private void Reloaded()
        {
            Console.WriteLine("Reloaded....");
            _isloaded = true;
            Console.WriteLine("Reload Complete....");
        }

        public void Shoot()
        {
            if (!_isloaded)
            {
                Console.WriteLine("Weapon can`t shoot....");
                Reloaded();
            }
            Console.WriteLine("BaH!\n");
            _isloaded = false;
        }
    }
}
