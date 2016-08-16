using System;
namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwait2.Run();
            Console.WriteLine("press any key");
            Console.Read();
        }
    }
}
