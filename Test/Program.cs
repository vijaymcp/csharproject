using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        // code added for enum value type
        enum Status
        {
            Open =1,
            Inprogress = 2,
            ReAssign = 3,
            Closed = 4
        }
        static void Main(string[] args)
        {
            Status st = Status.Open;
            Console.WriteLine("status is {0}", st);
            Console.ReadLine();

        }
    }
}
