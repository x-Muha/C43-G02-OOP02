using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_02
{
    internal struct Person
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion
        public Person(string name, int age)
        {
            Name = name; 
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
