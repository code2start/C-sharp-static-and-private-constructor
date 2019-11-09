using System;

namespace constructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SimpleClass.baseline);
            Counter.currentCount = 100;
            int c = Counter.IncrementCount();
            Console.WriteLine(c);
        }
    }
}
