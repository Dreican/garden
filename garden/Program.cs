using System;
using System.Collections.Generic;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new List<int>() {0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0};

            var result = Garden.CanPlante(garden, 2);
            
            Console.WriteLine($"{result.IsOk.ToString()} // {result.Reason}");
        }
    }
}
