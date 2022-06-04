using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotest
{
    public class Constread
    {
        const string ConstString = "lokesh";// at the compile time
        const long uid = 123456789123;
        public readonly string readonlydata;
        public Constread(string readString)
        {
            readonlydata = readString;
        }
        public void printConstRead()
        {
            Console.WriteLine("const string " + ConstString);
            Console.WriteLine("const  " + uid);
            Console.WriteLine("read only" + readonlydata);
            // readonlydata = null; it gives an error
        }
        public void Checkedex()
        {
            checked
            {
                Console.WriteLine("divisibile by 2");

                Console.WriteLine(10 / 2);

            }

        }
        public void UnCheckedex()
        {
            unchecked
            {
                Console.WriteLine(" divisible by zero exception ");

                Console.WriteLine(0 / 10);

            }
        }
    }
}
