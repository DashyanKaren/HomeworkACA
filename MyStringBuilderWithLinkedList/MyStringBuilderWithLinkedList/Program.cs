using System;

namespace MyStringBuilderWithLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedListString();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            Console.WriteLine(list.ToString()); 

            list.Add("d");
            Console.WriteLine(list.ToString());

        }
    }
}
