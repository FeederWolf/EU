﻿using System;
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
            
            int csat = 0;
            foreach (var i in europa)
            {
                if (i.datum.Date.Year == 2007)
                {
                    csat++;
                }
            }
            Console.WriteLine($"4. feladat: 2007-ben {csat} ország csatlakozott.");
            foreach (var i in europa)
            {
                if (i.orszag == "Magyarország")
                {
                    Console.WriteLine($"5. feladat: Magyarország csatlakozásának dátuma: {i.datum.ToString("yyyy.MM.dd")}");
                }
            }
            foreach (var i in europa)
            {
                if (i.datum.Date.Month == 05)
                {
                    Console.WriteLine("6. feladat: Májusban volt csatlakozás!");
                    break;
                }
            }
            
        }
    }
}
