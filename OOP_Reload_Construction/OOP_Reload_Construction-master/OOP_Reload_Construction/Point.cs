using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Reload_Construction
{//При створенні класу якщо створити в ньому декілька конструкторів цього ж класу, проте в якомусь будуть одні праметри в іншому інші а в іншому ще інші
    //То при оголошені в мейні в нас є змога вибрати стрілочаками який саме конструктор ми використовуємо
    class Point
    {

        //Наявність більш ніж 1 конструктора і є перегрузка
        public Point()
        {
            _x = _y = 1;
        }
        public Point(int x, int y)//при оголошені в класі потрібно буде вказати відразу координати по x та по y
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine("\n\t\t\t\tX: " + _x + "\tY: " + _y);
        }
    }
}
