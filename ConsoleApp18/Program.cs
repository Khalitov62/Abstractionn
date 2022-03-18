using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook(100, "4 hour", "DELL", "ASUS");
            Console.WriteLine(notebook.Name);
            notebook.Keyboard();
            

            PC pC = new PC("ASUS", "RAZER", "MONSTER", "ASUS");
            Console.WriteLine(pC.Name);
            pC.Keyboard();
        }
    }
}
