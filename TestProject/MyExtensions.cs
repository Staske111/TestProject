using System;
using System.Collections.Generic;
using TestProject;

namespace Extensions
{
    static class MyExtensions
    {
        public static bool IsExist(this Firm firm, Employee employee)
        {
            return firm.Employees.Contains(employee);
        }

        public static void Show_employees(this Firm firm)
        {
            Console.WriteLine("Менеджеры:");
            List<Manager> managers = firm.Get_of_t<Manager>();
            for (int i = 0; i < managers.Count; i++)
            {
                Console.WriteLine(managers[i].Full_name);
                Console.WriteLine($"Стаж: {managers[i].Exp} лет");
            }

            Console.WriteLine("Рабочие:");
            List<Workman> workers = firm.Get_of_t<Workman>();
            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine(workers[i].Full_name);
                Console.WriteLine($"Стаж: {workers[i].Exp} лет");
            }

            Console.WriteLine("Бригадиры:");
            List<Brigadier> brigadier = firm.Get_of_t<Brigadier>();
            for (int i = 0; i < brigadier.Count; i++)
            {
                Console.WriteLine(brigadier[i].Full_name);
                Console.WriteLine($"Стаж: {brigadier[i].Exp} лет");
            }

        }
    }
}
