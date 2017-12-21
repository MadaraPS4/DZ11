using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[6];
            employee[0].name = "Роман";
            employee[0].dolzhnost = "Мэнэджер";
            employee[0].salary = 120000;
            employee[0].joinDate = new DateTime(2000,5,21);

            employee[1].name = "Игорь";
            employee[1].dolzhnost = "Мэнэджер";
            employee[1].salary = 50000;
            employee[1].joinDate = new DateTime(2008, 5, 20);

            employee[2].name = "Вова";
            employee[2].dolzhnost = "Клерк";
            employee[2].salary = 80000;
            employee[2].joinDate = new DateTime(2003, 4, 22);

            employee[3].name = "Искандер";
            employee[3].dolzhnost = "Клерк";
            employee[3].salary = 60000;
            employee[3].joinDate = new DateTime(2005, 5, 21);

            employee[4].name = "Иман";
            employee[4].dolzhnost = "Клерк";
            employee[4].salary = 40000;
            employee[4].joinDate = new DateTime(2007, 5, 24);

            employee[5].name = "Владимир";
            employee[5].dolzhnost = "Босс";
            employee[5].salary = 300000;
            employee[5].joinDate = new DateTime(2004, 5, 21);


            // a) Полная информация обо всех сотрудниках

            Console.WriteLine("Информация обо всех сотрудниках\n");
            foreach(Employee e in employee)
            {
                Console.WriteLine("Имя: " + e.name);
                Console.WriteLine("Должность: " + e.dolzhnost);
                Console.WriteLine("Зарплата: " + e.salary);
                Console.WriteLine("Дата: " + e.joinDate);
                Console.WriteLine(new string('-', 25));
            }

            // b) Список менеджеров зарплата которых больше средней зарплаты всех клерков

            double clerkSalary = 0;
            int count = 0;
            for(int i=0; i<employee.Length; i++)
            {
                if (employee[i].dolzhnost == "Клерк")
                {
                    clerkSalary +=employee[i].salary;
                    count++;
                }
            }

            var q = from t in employee
                    where t.dolzhnost == "Мэнэджер" && t.salary > (clerkSalary/count)
                    select t;

            Console.WriteLine();
            Console.WriteLine("Список менеджеров зарплата которых больше средней зарплаты всех клерков:\n");

            foreach (var name in q)
            {
                Console.WriteLine(name.name);
            }

            // c) Список сотрудников принятых позже босса упорядоченные по алфавиту

            DateTime dateofBoss = new DateTime();
            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].dolzhnost == "Босс")
                {
                    dateofBoss = employee[i].joinDate;
                }
            }
            Console.WriteLine(new string('-',70));
            Console.WriteLine("Список сотрудников принятых позже босса упорядоченные по алфавиту:\n");

            var s = from t in employee
                    where t.joinDate > dateofBoss
                    orderby t.name
                    select t;

            foreach(var name in s)
            {
                Console.WriteLine(name.name);
            }
            Console.ReadKey();


        }
    }

    struct Employee
    {
        public string name;
        public string dolzhnost;
        public double salary;
        public DateTime joinDate;

    }
}
