using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHash
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
                Console.WriteLine(new Hasher(args[0]).Result);
        }
    }
}
