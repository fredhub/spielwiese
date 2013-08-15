using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spielwiese
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var s in args)
            {
                Console.WriteLine(s + ": " + s.Length);
            }
            Console.WriteLine("---");

            Array.ForEach(args, Console.WriteLine);
            Console.WriteLine("---");
            args.ToList().ForEach((s) => Console.WriteLine(s));
            var sinnlos = from s in args select s;
            Console.WriteLine(string.Join(",", args));

        }
    }
}
