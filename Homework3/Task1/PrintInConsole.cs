using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class PrintInConsole<T>
    {
        public void Print(T item)
        {
            Console.WriteLine($"You wrote down {item}");
        }

        public void PrintCollection(List<T> strings)
        {
            Console.WriteLine("You enterred:");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

    }
}
