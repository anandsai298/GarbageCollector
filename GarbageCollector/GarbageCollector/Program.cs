// See https://aka.ms/new-console-template for more information
using System;
namespace GarbageCollector;
class program
{
    static void Main(string[] args)
    {
        long mem1 = GC.GetTotalMemory(false);
        int[] values = new int[1000];//initialisation
        values = null;
        long mem2 = GC.GetTotalMemory(false);
        GC.Collect();
        long mem3 = GC.GetTotalMemory(false);
        Console.WriteLine(mem1);
        Console.WriteLine(mem2);
        Console.WriteLine(mem3);
        Console.WriteLine("###################");
        long bytes1= GC.GetTotalMemory(false);
        byte[] memory= new byte[1000*200*10];
        memory[0] = 1;
        long bytes2 = GC.GetTotalMemory(false);
        long bytes3 = GC.GetTotalMemory(true);
        Console.WriteLine(bytes1);
        Console.WriteLine(bytes2);
        Console.WriteLine(bytes3);
    }
}

