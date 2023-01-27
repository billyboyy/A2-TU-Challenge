using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return true;
            }
            else
            {
                foreach(char c in input)
                {
                    if (c != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}
