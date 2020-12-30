using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Static_class
{
    class MyClass
    {
        public int a;
        public void PrintA()
        {
            Console.WriteLine(a);
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        //Ця змінна буде спільна для всіх оьєктів даного класу
        public static int b;//Память яка буде виділятись для даного поля буде виділятись для всіх обєктів даного класу(MyClass)

        public void PrintB()
        {
            Console.WriteLine(b);
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private static int c;
        public void SetC(int c)
        {
            MyClass.c = c;//замість this. можемо зсилатись на сам цей клас          this це силка обєкта цього класу на самого себе а так як поле статичне ми не можемо
        }
        public void PrintC()
        {
            Console.WriteLine(c);
        }

    }

}
