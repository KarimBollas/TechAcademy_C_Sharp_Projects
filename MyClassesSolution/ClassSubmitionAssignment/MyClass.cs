using System;


namespace ClassSubmitionAssignment
{
    public class MyClass
    {

        /*-------------1. Create a class. In that class, create a void method that outputs an integer. 
         * Have the method divide the data passed to it by 2.-------------*/
        public void DivideBy2 (int number) // void method 
        {
            int output = number / 2;   // integer paramater divided by 2 
            Console.Write(output); // outputs an integer

        }

        /*----------4. Create a method with output parameters---------*/
        /*----------5.Overload a method.---------*/
        public void DivideBy2(out double halfNumber, int number) // overload void method with output parameters
        {
            halfNumber = (double)number / 2.0;
        }


}
}
