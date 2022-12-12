using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class FindMaximum
    {
        public static int FindIntMax(int num1,int num2,int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >0)
            {
                return num3;
            }
            return 0;
        }
        public static float FindfloatMax(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return 0;
        }
        public static string FindStringMax(string myString1, string myString2, string myString3)
        {
            if (String.Compare(myString1, myString2)>0 && String.Compare(myString1, myString3) > 0)//1>2&1>3
            {
                return myString1;
            }
            if (String.Compare(myString2, myString1) > 0 && String.Compare(myString2, myString3) > 0)
            {
                return myString2;
            }
            else 
            {
                return myString3;
            }
            
                
            
        }
    }
}