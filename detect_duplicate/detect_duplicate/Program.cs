using System.Linq;
using System.Drawing;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace detect_duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList
            {
                "AAAAA",
                "AAAAA",
                "BBBBB",
                "CCCCC",
                "DDDDD",
                "jd",
                "EEEEE",
                "FFFFF",
                "DDDDD",
                "jd"
            };

            int count = list.ToArray().GroupBy(q => q).Count(q => q.Count() > 1);
            Console.WriteLine(count);

            int countDup = list.Count - list.OfType<object>().Distinct().Count();
            Console.WriteLine(countDup);

            Console.WriteLine(list.ToArray().GroupBy(i => i).Count(g => g.Count() > 1));
        }
    }
}
