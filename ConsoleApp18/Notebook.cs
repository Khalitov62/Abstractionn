using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Notebook:Computer
    {
        public byte Charge;
        public string ChargekeepTime;

        public Notebook(byte charge, string chargekeeptime, string name, string brand) : base(name, brand)
        {
            Charge = charge;
            ChargekeepTime = chargekeeptime;
        }
        

        public override void Keyboard()
        {
            Console.WriteLine("Notebook da klaviatura bitisik olur");
        }
        public void Info()
        {
            Console.WriteLine($"Charge: {Charge}, Chargekeeptime: {ChargekeepTime}, Name: {Name}, Brand: {Brand}");
        }
    }
}
