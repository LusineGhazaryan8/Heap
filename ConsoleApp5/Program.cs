using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeapLusine heap = new HeapLusine();

            heap.SortHeap();
            Console.ReadLine();
        }
    }
}
