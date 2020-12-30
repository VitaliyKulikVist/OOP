using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Metod_Class
{
    class Car
    {
        private int speed = 0;//ця змінна буде працювати лише в цьому класі оскільки рівень доступу до неї private
        public void PrintSpeed()
        {
            if (speed==0)
            {
                Console.WriteLine("Stoped");
            }
            if (speed > 0)//Якщо швидкість більше 0 значить виводимо повідомлення з показником швидкості вперед
            {
                Console.WriteLine("We are moving forward at speed: " + speed+"km/h");
            }
            if (speed < 0)//Якщо швидкість менша 0 значить виводимо повідомлення з показником швидкості назад
            {
                Console.WriteLine("We go back at speed: " + -speed + "km/h");
            }
        }
        public void DriveForward()//рух вперед
        {
            speed = 60;
        }
        public void Stop()
        {
            speed = 0;
        }
        public void DriveBackward()
        {
            speed = -10;
        }
    }
}
