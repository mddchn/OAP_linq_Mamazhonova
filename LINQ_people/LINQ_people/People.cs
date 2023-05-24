using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_people
{
    class People
    {
        public string name;
        public string surname;
        public string otchestvo;
        public int age;
        public double weight;
        public People(string _name, string _surname, string _otchestvo, int _age, double _weight)
        {
            name = _name;
            surname = _surname;
            otchestvo = _otchestvo;
            age = _age;
            weight = _weight;
        }
    }
}
