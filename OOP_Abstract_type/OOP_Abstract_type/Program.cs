using System;

namespace OOP_Abstract_type
{
    //abstract class Player//abstract - абстрактний клас це певна ідея, часткова реалізація яку можна використовувати лише в наслідниках цього класу
    //{
    //    public void Fire()
    //    {

    //    }
    //}

    abstract class Weapon//abstract - абстрактний клас це певна ідея, часткова реалізація яку можна використовувати лише в наслідниках цього класу
    {
        public abstract int Damage { get; }// - абстрактне свойство
        //public Weapon(int a, int b)//можна створювати конструктори і в абстрактних класах
        //{

        //}
        public abstract void Fire();// - абстрактний метод в середині абстрактного класу
        public void ShpwInfo()// - звичайний метод який виводить тип зброї а також урон з цієї зброї
        {
            Console.WriteLine($"{GetType().Name}\t Damage: {Damage}");
        }

        
    }

    class Gun : Weapon//Наслідування класом Gun абстрактного класу Weapon (з усімома його методами)
    {
        public override int Damage { get { return 5; } }

        public override void Fire()//обовязково мусимо реалізовувати всі методи абстрактного клсу           override - перевизначення
        {
            Console.WriteLine("Bah!");
        }
    }
    class LaserGun : Weapon//Наслідування класом Gun абстрактного класу Weapon (з усімома його методами)
    {
        public override int Damage => 7;

        public override void Fire()//обовязково мусимо реалізовувати всі методи абстрактного клсу           override - перевизначення
        {
            Console.WriteLine("Piu!");
        }
    }
    class Bow : Weapon//Наслідування класом Gun абстрактного класу Weapon (з усімома його методами)
    {
        public override int Damage { get { return 3; } }

        public override void Fire()//обовязково мусимо реалізовувати всі методи абстрактного клсу           override - перевизначення
        {
            Console.WriteLine("Skibdish!");
        }
    }


    class Player//abstract - абстрактний клас це певна ідея, часткова реалізація яку можна використовувати лише в наслідниках цього класу
    {
        public void Fire(Weapon weapon)//в методі використовуємо абстрактий клас
        {
            weapon.Fire();//викликаємо абстрактний мотод абстрактного класу Weapon
        }
        public void CheckInfo(Weapon weapon)
        {
            weapon.ShpwInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //Gun gun = new Gun();
            //player.Fire(gun);
            Weapon[] weapons = { new Gun(), new LaserGun(), new Bow() };
            foreach (var wea in weapons)
            {
                player.CheckInfo(wea);//перевірка яка зброя
                player.Fire(wea);//вистріл з даної зброї
                Console.WriteLine();
            }
        }
    }
}
