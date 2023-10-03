using System;

//ref link:https://www.youtube.com/watch?v=TuGqrFBY6dE&list=PLF932FF551E0ADD16&index=6
// for loop - rearrange while loop

class MyClass
{
    static void Main()
    {
        //int i = 1;
        //while (i <= 20)
        //{
        //    Console.WriteLine(i);
        //    i = i + 1;
        //}
        //Console.WriteLine("Done"); // output 1 to 20 Done

        //for (int i = 1; i <= 20; i = i + 1)
        for (int i = 1; i <= 20; i++)   // i = i + 1 same as i++
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Done");   // output 1 to 20 Done
    }
}