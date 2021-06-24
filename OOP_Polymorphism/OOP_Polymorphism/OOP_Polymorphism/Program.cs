using System;

namespace OOP_Polymorphism
{
    class Car
    {
        protected void StartEngine()//protected - щоб можна було переназначати і використовувати у інших класах
        {
            Console.WriteLine("Engine on!");
        }
        public virtual void Drive()//virtual - треба для того щоб можна було переоприділити метод
        {
            StartEngine();
            Console.WriteLine("Car is run");
        }
    }

    class SportCar: Car//наслідуємо в класі SportCar клас Car(повне наслідування)
    {
        public override void Drive()//override - переоприділення методу в класі який наслідує цей клас
        {
            StartEngine();

            //base.Drive();//Виклик методу Drive() з базового класу
            Console.WriteLine("Car runing, very Fast");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();

            Person person = new Person();

            //person.Drive(new Car());//("Car is run");
            person.Drive(new SportCar());//("Car runing, very Fast");
        }
    }
}
