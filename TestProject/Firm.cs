using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Firm
    {
        public List<Employee> Employees { get; }
        public Firm()
        {
            Employees = new List<Employee>();
        }

        public void Add(Employee sotrudnik)
        {
            Employees.Add(sotrudnik);
        }

        public void Remove(Employee sotrudnik)
        {
            Employees.Remove(sotrudnik);
        }


        public List<T> Get_of_t<T>()
        {
            List<T> newlist = Employees.Where(x => x is T).Cast<T>().ToList();
            return newlist;
        }

        public int Count_of_t<T>()
        {
            return Get_of_t<T>().Count();
        }


        //Operators
        public static Firm operator +(Firm firm, Employee employee)
        {
            firm.Add(employee);
            return firm;
        }

        public static Firm operator -(Firm firm, Employee employee)
        {
            firm.Remove(employee);
            return firm;
        }
    }
}
