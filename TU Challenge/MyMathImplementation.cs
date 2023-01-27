using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int  b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 149)
            {
                throw new ArgumentException(String.Format("vous ne pouvez pas avoir plus de 125 ans", age),
                                          "num");
            }
            else if (age > 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEven(int a)
        {
            return ((a & 1) == 0);
        }

        public static bool IsDivisible(int a, int b)
        {
            return ((b+a & 1) == 0);
        }

        public static bool IsPrimary(int a)
        {
            if (a % 2 == 0 && a != 2)
            {
                return false;
            }
            else if (a % 3 == 0 && a != 3)
            {
                return false;
            }
            else if (a % 5 == 0 && a != 5)
            {
                return false;
            }
            else if (a % 7 == 0 && a != 7)
            {
                return false;
            }
            else return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                bool result = IsPrimary(i);
                if (result)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        
        public static bool IsListInOrder(List<int> list)
        {
            if (list.Count() < 2)
            {
                return true;
            }
            for (int i = 0; i < list.Count() - 1; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
