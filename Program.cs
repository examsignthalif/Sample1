using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethod ob = new myMethod();
            Console.WriteLine(ob.Add(5,10));
            Console.WriteLine(ob.Add(20,30));
            Console.WriteLine(ob.Add(5,50));
        }
    }
}
