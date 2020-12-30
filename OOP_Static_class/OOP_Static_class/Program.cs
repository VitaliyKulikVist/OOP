using System;

namespace OOP_Static_class
{
    class Program
    {//ООП
        //Ключеве поле static
        //Ститичні поля Класу
        static void Main(string[] args)
        {
            Console.WriteLine("My Class A: ");
            MyClass myClass1 = new MyClass();
            myClass1.a = 11;
            myClass1.PrintA();
            MyClass myClass2 = new MyClass();
            myClass2.a = 22;
            myClass2.PrintA();

            Console.WriteLine("My Class B: ");
            //Для роботи з статік НЕ потрібно створювати новий обєкт класу (MyClass myClass1 = new MyClass();)
            MyClass.b = 33;//необхідно на пряму визивати клас і в ньому буде наша змінна з типом СТАТІК
            myClass1.PrintB();
            MyClass.b = 44;//данні зберігаються в окремій області памяті на рівні самого класу myClass) тому це поле буде спільним для всіх обєктів даного класу
            myClass1.PrintB();

            Console.WriteLine("\nMy Class С: ");
            //використаємо "чужі" обумовлення НО оскільки змінна статік, то вона спільна для всіх обєктів класу myClass а отже і можемо використовувати з ким завгодно
            myClass1.SetC(55);//Використаємо чуже оголошення і звернемось до методу задання значення
            myClass1.PrintC();//зчитаємо з "чужого" оголошення проте метод саме для відображення цієї змінної
            Console.Write("Перепровіримо чи не переписались данні в клас А(11)= ");
            myClass1.PrintA();
            //перевіримо чи данні не перекриваються
            myClass2.SetC(66);
            myClass2.PrintC();
            Console.Write("Перепровіримо чи не переписались данні в клас А(22)= ");
            myClass2.PrintA();




            Console.ReadKey();
        }
    }
}
