using System;

namespace Open_Lab_03._09
{
    public class Numbers
    {
        public bool IsPrimeNumber(int num)
        {

            for (int num2 = 2; num2 < num; num2++)
                if (num % num2 == 0)
                {
                    return false;
                }
            if (num <= 1)
            {
                return false;
            }        
                return true;


        }
    }
}
