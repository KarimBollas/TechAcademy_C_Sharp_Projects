using System;
using System.Collections.Generic;


namespace MainMethodAssignment
{
    public class Operations
    {

        //method that will take in an integer
        public int ConvertFromKBTob(int kilobytes) 
        {            
            return (kilobytes*1024*8); // operation for the integer then return the answer as an integer
        }

        //overload method ConvertFromKBTob that will take in a decimal
        public int ConvertFromKBTob(decimal kilobytes)
        {
            return ((int)(kilobytes)* 1024 * 8)+1; // different operation for the decimal (+1) then return the answer as an integer
        }

        //overload method ConvertFromKBTob that will take in a string
        public int ConvertFromKBTob(string kilobytes)
        {            
            return (Convert.ToInt32(kilobytes) * 1024 * 8) -1; // (first convert to integer), different operation (-1)  then return the answer as an integer
        }
    }
}
