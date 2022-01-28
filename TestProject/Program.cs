using System;
using System.Collections.Generic;
using System.Linq;
using Extensions;

namespace TestProject
{
    class Program
    {
        static void Main()
        {
            Firm micr = new Firm();
            Workman worker1 = new Workman { Full_name = "Ivan Ivanov", Exp = 3 };
            micr += worker1;
            Workman worker2 = new Workman { Full_name = "Andrey Andreevich", Exp = 5 };
            micr += worker2;
            Workman worker3 = new Workman { Full_name = "Igor Igorevich", Exp = 1 };
            micr += worker3;

            Manager manager1 = new Manager { Full_name = "Inna Valeryevna", Exp = 4 };
            micr += manager1;
            Manager manager2 = new Manager { Full_name = "Anna Valeryevna", Exp = 3 };
            micr += manager2;

            Brigadier brigadier1 = new Brigadier { Full_name = "Aleksey Valeryevich", Exp = 3 };
            micr += brigadier1;
            Brigadier brigadier2 = new Brigadier { Full_name = "Alina Stanislavovna", Exp = 6 };
            micr += brigadier2;
            micr -= worker2;


            List<Workman> newlist = micr.Get_of_t<Workman>();//получаем всех рабочих
            Console.WriteLine("Рабочие: ");
            Console.WriteLine(string.Join(Environment.NewLine, newlist.Select(x => x.Full_name)));//отображаем всех рабочих
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Наличие рабочего 2 в фирме: " + micr.IsExist(worker2));
            Console.WriteLine("Наличие рабочего 3 в фирме: " + micr.IsExist(worker3));

            Console.WriteLine("Количество менеджеров: " + micr.Count_of_t<Manager>());

            Console.WriteLine("Список сотрудников");
            micr.Show_employees();
        }
    }

    

    
    
    
}
