using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CheckNumber
    {
        public static bool IsPrime(int n)
        {
            int c = 0;
            for (int i = 2; i < n/2; i++)
            {
                if(n%i == 0)
                {
                    c++;
                }
            }
            
            if(c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Reverse(int n)
        {
            int m = n;
            int rev = 0;
            while (m!=0)
            {
                int r = m % 10;
                rev = (rev * 10) + r;
                m = m / 10;

            }

            return rev;
        }

        public static int Sum(int n)
        {
            int m = n;
            int sum = 0;
            while (m != 0)
            {
                int r = m % 10;
                sum += r;
                m = m / 10;
            }

            return sum;
        }

        public static bool IsArmstrong(int n)
        {
            int m = n;
            int d = 0;
            int sum = 0;
            while (m != 0)
            {
                d++;
                m=m / 10;
            }
            m = n;
            while (m != 0)
            {
                int r = m % 10;
                int newnum = 1;
                for (int i = 0; i < d; i++)
                {
                    newnum *= r ;
                }
                sum += newnum;
                m = m / 10;
            }
            return sum == n;
        }

        public static bool IsNeon(int n)
        {
            int newNum = n;
            int sqnum = newNum*newNum;
            int m=sqnum;
            int sum = 0;

            while (m != 0)
            {
                int r=m % 10;
                sum+=r;
                m = m / 10;
                
            }
            if (n == sum)
                return true;
            else
                return false;

        }

    }
}
