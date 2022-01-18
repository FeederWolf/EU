using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;
using System.Text;

namespace EU
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EU_list> europa = new List<EU_list>();
            foreach (var i in File.ReadAllLines("EUcsatlakozas.txt"))
            {
                europa.Add(new EU_list(i));
            }
            Console.WriteLine($"3. feladat: EU tagállamainak száma: {europa.Count} db");
        }
    }
}
