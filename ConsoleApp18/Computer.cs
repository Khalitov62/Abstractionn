using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    abstract class Computer
    {
        public string Name;
        public string Brand;

        public Computer(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }
        public abstract void Keyboard();
        
    }
}
