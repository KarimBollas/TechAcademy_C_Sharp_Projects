using System;


namespace MethodClassSubmission
{
    class MyMath3
    {
        public void Factorial(out int factorial, int number)
        {
            //initilize factorial as number
            factorial = number;
            //runs trhough whole numbers from number to 1 and multiply 
            for (int i=number; i > 2; i--)
            {
                factorial = factorial * (i - 1);
            }
            Console.Write(number);
        }
    }
}
