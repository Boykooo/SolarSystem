using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolarSystem
{
    class Check
    {
        public static bool CheckInput(string s)
        {
            double k;
            return Double.TryParse(s, out k);
        }
    }
}
