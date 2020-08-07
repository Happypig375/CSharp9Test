using System;

namespace CSharp9
{
    public class Class1
    {
        public static void Main()
        {
            foreach (var x in new[] { 1, 4, 3, 2 })
            {
                Console.WriteLine(x is 2 or 5);
            }
        }
    }
}