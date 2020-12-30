using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Construction_of_Class
{
    class Point
    {
        public Point (int x, int y)//при оголошені в класі потрібно буде вказати відразу координати по x та по y
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
