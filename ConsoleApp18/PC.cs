using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class PC:Computer
    {
        public string Monitor;
        public string Mouse;

        public PC(string monitor, string mouse,string name, string brand):base(name,brand)
        {
            Monitor = monitor;
            Mouse = mouse;
        }
        public override void Keyboard()
        {
            Console.WriteLine("PC de ayri olur");
        }
        public void Info()
        {
            Console.WriteLine($"Monitor: {Monitor}, Mouse: {Mouse}, Name: {Name}, Brand: {Brand}");
        }
    }
}
