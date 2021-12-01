using System;
using System.Collections.Generic;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {


            //array
            //int[] numarray = new int[5];
            //numarray[0] = 5;
            //numarray[1] = 2;
            //numarray[2] = 10;
            //numarray[3] = 200;
            //numarray[4] = 5000;


            //int[] numArray1 = new int[] {5,2,10,200,5000, 600, 2300};
            //int[] numArray2 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;           

            //Console.WriteLine(numarray[5]);

            List<int> initList = new List<int>();
            initList.Add(4);
            initList.Add(10);
            initList.Remove(10);

            List<string> initListS = new List<string>();
            initListS.Add("Hola");
            initListS.Add("Mundo");
            initListS.Remove("Hola");

            byte[] byteArray = new byte[50];
        }
    }
}
