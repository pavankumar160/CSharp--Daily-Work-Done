

using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    class MyClass
    {
        public int[] data = new int[1000]; // allocate some memory
    }

    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        // Create 5 objects
        MyClass obj1 = new MyClass(); // used normally
        MyClass obj2 = new MyClass(); // used in loop
        MyClass obj3 = new MyClass(); // used in loop
        MyClass obj4 = new MyClass(); // unused
        MyClass obj5 = new MyClass(); // used later

        Console.WriteLine("Initial Generations:");
        PrintGen(obj1, "obj1");
        PrintGen(obj2, "obj2");
        PrintGen(obj3, "obj3");
        PrintGen(obj4, "obj4");
        PrintGen(obj5, "obj5");

        // Use obj2 and obj3 in loop
        for (int i = 0; i < 5; i++)
        {
            obj2.data[0] = i;
            obj3.data[0] = i;
        }

        // Force garbage collection multiple times
        for (int i = 0; i < 3; i++)
        {
            sw.Restart();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            sw.Stop();

            Console.WriteLine($"\nAfter GC #{i + 1} (took {sw.ElapsedMilliseconds} ms):");
            PrintGen(obj1, "obj1");
            PrintGen(obj2, "obj2");
            PrintGen(obj3, "obj3");
            // obj4 is unused, may be collected
            PrintGen(obj5, "obj5");
        }

        // Finally use obj5
        obj5.data[0] = 99;
        Console.WriteLine("\nAfter using obj5:");
        PrintGen(obj5, "obj5");
    }

    static void PrintGen(object obj, string name)
    {
        if (obj == null)
            Console.WriteLine($"{name} has been collected.");
        else
            Console.WriteLine($"{name} is in Gen {GC.GetGeneration(obj)}");
    }
}
