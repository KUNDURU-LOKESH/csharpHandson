using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotest
{
    public class tupleDemo
    {
        public void sample()
        {
            var abc=Tuple.Create(1,2,3);
            Console.WriteLine(abc);
            var author = new Tuple<string, string, int>("Mahesh Chand", ".NET Programming", 2003);
            Console.WriteLine(author);
            Console.WriteLine("author name"+author.Item1+"book name"+author.Item2+"year of publication"+author.Item3);

        }
        public void showdetails()
        {
            // Declare the array of four elements:  
            int[][] numArray = new int[4][];
            // Initialize the elements:  
            numArray[0] = new int[2] { 7, 9 };
            numArray[1] = new int[4] { 12, 42, 26, 38 };
            numArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
            numArray[3] = new int[3] { 4, 6, 8 };
            // Display the array elements:  
            for (int i = 0; i < numArray.Length; i++)
            {
                System.Console.Write("Element({0}): ", i + 1);
                for (int j = 0; j < numArray[i].Length; j++)
                {
                    System.Console.Write(numArray[i][j] + "\t");
                }
                System.Console.WriteLine();
            }
        }

        public static void mydata(ref int value)
        {
            int Value1=value;
            Value1 = Value1 + 1;
            Console.WriteLine(Value1);
        }
        public static void stdInfo(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public void nullable()
        {
            string name = null;
            int? num = null;
            Console.WriteLine("nullable type string name:"+name);
            Console.WriteLine("nullable int"+num);
        }
    }

}
