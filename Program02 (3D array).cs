using System;

namespace Day4
{
    class Prog2
    {
        public static void Main(string[] args)
        {
            //declare a 3 dimensional array
            //e.g. of use: comparing sales of two products in the three months in each quarter
            int[,,] A = new int[,,]     //4 X 3 X 2 array
            {
                {
                    {1,2}, {3,4}, {9,10}
                },
                {
                    {5,6}, {7,8}, {11,12}
                },
                {
                    {11,12}, {13,14}, {9,10}
                },
                {
                    {15,16}, {17,18}, {11,12}
                },
            };

            Console.WriteLine(A[3, 2, 0]);      //remember arrays always start from 0
                
        }
    }
}
