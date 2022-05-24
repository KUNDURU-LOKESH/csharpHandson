using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Myproject
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Create an array to hold integer values 0 through 9 
             * Create an array of the names "Tim", "Martin", "Nikki", &"Sara" 
             * Create an array of length 10 that alternates between true and false values, starting with true

            List of Flavors.

            Create a list of ice cream flavors that holds at least 5 different flavors(feel free to add more than 5!) 
            Output the length of this list 
            after building it Output the third flavor in the list, 
            then remove this value 
            Output the new length of the list*/
            int[] abc = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = new string[10] { "ajay", "jafar", "lokesh", "vinay", "siddu", "abhi", "sai", "kumar", "jhon", "ravi" };
            string[] bool1 = new string[10] { "True", "False", "True", "False", "True", "False", "True", "False", "True", "False" };
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine("At Index["+i+"]="+ abc[i]);

            }
            Console.WriteLine("*************");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
            for (int i = 0; i < bool1.Length; i++)
            {
                Console.WriteLine(bool1[i]);
            }
            Console.WriteLine("*************");
            List<string> icecream = new List<string>();
            icecream.Add("vineela");
            icecream.Add("strawberry");
            icecream.Add("buttersoch");
            icecream.Add("choclate");
            icecream.Add("pineapple");
            icecream.Add("badam");
            icecream.Add("pista");
            foreach (string i in icecream)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
            Console.WriteLine("the list elements are:"+icecream.Count);
            Console.WriteLine("the third element in the list:"+icecream[3]);
            icecream.RemoveAt(3);
            Console.WriteLine("after removing the 3 rd elements in the list");
            Console.WriteLine("*************");
            foreach (string i in icecream)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************");
            Console.WriteLine("the list elements after removing are:"+icecream.Count);
            Console.WriteLine("*************");
        }
    }
}
