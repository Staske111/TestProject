using System;

namespace TestProject
{
    abstract class Employee
    {
        public string Full_name { get; set; }
        public int Exp { get; set; }

        public abstract void Work();
    }

    class Workman : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Выпуск продукции");
        }
    }

    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Сбор заказов");
        }
        public void Give_assignment()
        {
            Console.WriteLine("Выдача задания");
        }
    }

    class Brigadier : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Закупка материалов");
        }

        public void Workers_check()
        {
            Console.WriteLine("Проверка рабочих");
        }
    }
}
