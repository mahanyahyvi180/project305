using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp163
{
    class Program
    {
        static void Main(string[] args)
        {
            object objectValue = "hello";
            var stringValue = "goodbye";
            char[] characterArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
            var booleanValue = true;
            var characterValue = 'z';
            var integerValue = 7;
            var longValue = 1000000L;
            var floatValue = 2.5F;
            var doubleValue = 33.333;
            var buffer = new StringBuilder();

            buffer.Append(objectValue);
            buffer.Append(" ");
            buffer.Append(stringValue);
            buffer.Append(" ");
            buffer.Append(characterArray);
            buffer.Append(" ");
            buffer.Append(characterArray, 0, 3);
            buffer.Append(" ");
            buffer.Append(booleanValue);
            buffer.Append(" ");
            buffer.Append(characterValue);
            buffer.Append(" ");
            buffer.Append(integerValue);
            buffer.Append(" ");
            buffer.Append(longValue);
            buffer.Append(" ");
            buffer.Append(floatValue);
            buffer.Append(" ");
            buffer.Append(doubleValue);

            Console.WriteLine($"buffer={buffer.ToString()}");
            Console.ReadLine();

        }
    }
}
