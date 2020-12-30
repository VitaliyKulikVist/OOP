using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation
{
    class Gun
    {/// <summary>
    /// ///////////////////////////////Інкапсуляція виражається в закриті можливостей обєкта, захищаємо від зовнішнього впливу, 
    /// і даємо можливість взаємодії на нього лише в межах даного класу і методами які в цьому класі.
    /// Проте результат взаємодії можемо використовувати в основному класі
    /// </summary>
        private bool isloaded;//Стан або готове до стрільби або НЕ готове           (заряжена=true      НЕ заряжена=false)

        private void Reloaded()//Функція автоматичної перезарядки пушки
        {
            Console.WriteLine("Reloaded....");//Перезаряджаємо
            isloaded = true;//міняємо стан на готову до стрільби
            Console.WriteLine("Reload Complete....");//Виводимо що перезарядка завершена можна стріляти
        }

        public void Shoot()//метод самої стрільби
        {
            if(!isloaded)//Умова перевірки на готовність стріляти
            {
                Console.WriteLine("Weapon can`t shoot....");//якщо умова відповідає що isloaded=false, тоді вивести "Зброя не може стріляти"
                Reloaded();//Викликаємо метод автоматичної перезарядки зброї
            }
            Console.WriteLine("BaH!\n");//Якщо всі умови виконані тоді Стріляємо
            isloaded = false;// після стрільби змінюємо готовність стрільби на false що заставить знову по колу перезаряджатись і стріляти знову(якщо зациклити)
        }

    }
}
