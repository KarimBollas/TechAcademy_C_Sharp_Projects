using System;

namespace MethodSubmission
{
    public class MathOperations
    {
        public int Power(int number, int power=2)
        {
            //if power equals 0, then result = 1
            if (power == 0)
            {
                return 1;
            }
            else
            {
                //multiply number by itself power times 
                for (int i = 1; i < power; i++)
                {
                    number *= number;
                }
                return number;
            }                
            
        }
    }
}
