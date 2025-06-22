using System;

partial class Program
{
    static int Add(int i, int j)
{
    return i+j;
}
    static void Main(string[] args)
    {
        Console.WriteLine("Hello " + Add(51, 19));
    }
}
