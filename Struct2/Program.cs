using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct2
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] students = new Students[5];

            students[0].name = "Baha";
            students[0].surname = "Zeityn";
            students[0].group = "SDP-161";
            students[0].gender = Gender.Male;
            students[0].averageScore = 4.5;
            students[0].dohodFamily = 60000;
            students[0].formaObuchenia = FormaObuchenia.Ochniy;

            students[1].name = "Ismail";
            students[1].surname = "Gadenov";
            students[1].group = "SDP-161";
            students[1].gender = Gender.Male;
            students[1].averageScore = 4;
            students[1].dohodFamily = 30000;
            students[1].formaObuchenia = FormaObuchenia.Ochniy;

            students[2].name = "Igor";
            students[2].surname = "Prohorov";
            students[2].group = "SDP-162";
            students[2].gender = Gender.Male;
            students[2].averageScore = 3.5;
            students[2].dohodFamily = 40000;
            students[2].formaObuchenia = FormaObuchenia.Ochniy;

            students[3].name = "Kamen";
            students[3].surname = "Elya";
            students[3].group = "SDP-161";
            students[3].gender = Gender.Male;
            students[3].averageScore = 2.5;
            students[3].dohodFamily = 50000;
            students[3].formaObuchenia = FormaObuchenia.Ochniy;


            students[4].name = "Stanislav";
            students[4].surname = "Belinskyu";
            students[4].group = "SDP-161";
            students[4].gender = Gender.Male;
            students[4].averageScore = 2;
            students[4].dohodFamily = 70000;
            students[4].formaObuchenia = FormaObuchenia.Ochniy;


            Console.WriteLine("Список студентов по приоритету выдачи общежития:\n");


            var q = from t in students
                    where t.dohodFamily < 48000
                    select t;

            foreach(var name in q)
            {
                Console.WriteLine(name.name);
            }

            var s = from t in students
                    where t.dohodFamily > 48000
                    orderby t.averageScore descending
                    select t;

            foreach(var name in s)
            {
                Console.WriteLine(name.name);
            }

            Console.ReadKey();
        }

    }


    struct Students
    {
        public string name;
        public string surname;
        public string group;
        public double averageScore;
        public double dohodFamily;
        public Gender gender;
        public FormaObuchenia formaObuchenia;

    }

    enum Gender
    {
        Male,
        Female
    }

    enum FormaObuchenia
    {
        Ochniy,
        Zaochniy
    }
}
