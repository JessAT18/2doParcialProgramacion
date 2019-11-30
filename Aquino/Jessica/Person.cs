using System;

namespace Jessica
{
    public class Person
    {
        private string _name;
        private double _savemoney;
        public string Name { get { return _name; } }
        public double SaveMoney { get { return _savemoney; } }
        public Person(string name, double savemoney) { _name = name; _savemoney = savemoney; }


        public void Save(double save) { _savemoney += save; }
        public void Spend(double save) { _savemoney -= save; }
        public void ChangeName(string name) { _name = name; }

    }

}
