using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoExercices
{
    public class StringExercices
    {
        public string withoutX(string str)
        {
            str = str.ToLower();
            if (str.StartsWith("x"))                    
                str = str.Substring(1);
            if (str.EndsWith("x"))
                str = str.Substring(0, str.Length - 1);
            return str;
        }
    }
}
