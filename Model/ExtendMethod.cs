using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model
{
    public static class ExtendMethod
    {
        public static double ToDouble(this string strVal)
        {
            double d = 0;
            if (double.TryParse(strVal, out d))
            {
                return d;
            }               
            return 0;
        }
    }
}