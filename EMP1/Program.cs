using System;

namespace EMP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp DMart = new Emp("DMart", 20, 2, 10);
            Emp Reliance = new Emp("Reliance", 30, 2, 20);
            DMart.check();
            Reliance.check();
        }
    }
}
