using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoExercices
{
    public class FizzBuzz
    {
        public string CheckFizzBuzz(int x)
        {
            string str = x.ToString();
            if (x % 3 == 0)
                str = "Fizz";
            if (x % 5 == 0)
                if (str == "Fizz")
                    str = "FizzBuzz";
                else
                    str = "Buzz";

            return str;
        }
    }
}
