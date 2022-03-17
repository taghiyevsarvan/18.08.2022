using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;


        public string Name 
        {
            get { return _name; }

            set 
            { 
                if(CheckLetter(value))
                    _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set 
            {
                if(CheckLetter(value))
                    _surname= value;
            }
        }

        public double Salary 
        { get { return _salary; }
            set
            {
                if(value>=250)
                    _salary = value;
            }
        }

        public bool CheckLetter(string sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                if(!char.IsLetter(sentence[i]))
                    return false;
                    
            }
            return false;
        }


    }
}
