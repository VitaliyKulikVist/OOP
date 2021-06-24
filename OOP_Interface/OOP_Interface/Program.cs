using System;

namespace OOP_Interface
{
    interface IDateProvider//реалізація інтерфейсу(в ньому не може бути конструкторів на відмінну від абстрактного класу, і не може містити полів)
    {
        //не повинен містити конкретної реалізації а лише загальну "поведінку" за допомогою методів
        //модифікатори доступу весь час public і не можуть бути іншими
        string GetData();
    }

    interface IDataProcesspr
    {
        void ProcessorData(IDateProvider dateProvider);
    }

    class ConsoleDateProcessor : IDataProcesspr// - клас ConsoleDateProcessor реалізовує інтерфейс IDataProcesspr
    {
        public void ProcessorData(IDateProvider dateProvider)
        {
            Console.WriteLine(dateProvider.GetData());
        }
    }



    class DbDataProvider : IDateProvider
    {
        public string GetData()
        {
            return "data done in BD!";
        }
    }
    class FileDateProvider : IDateProvider
    {
        public string GetData()
        {
            return "data done in File!";
        }
    }
    class APIDateProvider : IDateProvider
    {
        public string GetData()
        {
            return "data done in API!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataProcesspr dataProcesspr = new ConsoleDateProcessor();//до інтерфейсу присвоюємо клас який наслідує цей же інтерфейс(реалізовує)

            dataProcesspr.ProcessorData(new DbDataProvider());
            dataProcesspr.ProcessorData(new FileDateProvider());
            dataProcesspr.ProcessorData(new APIDateProvider());
        }
    }
}
