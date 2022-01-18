using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
    class EU_list
    {
        public string orszag { get; set; }
        public DateTime datum { get; set; }
        public EU_list(string sor)
        {
            string[] s = sor.Split(';');
            orszag = s[0];
            datum = DateTime.Parse(s[1]);
        }
    }
}
