using System;

namespace Day4
{
    class Prog1
    {
        public static void Main(string[] args)
        {
            int[] A = new int[3];
            A[0] = 100;
            A[1] = 200;
            A[2] = 300;
            //A[3] = 400;       //this will throw an 'Index out of Range' exception error

            int i = 1;
            A[i] = 1000;        //replaces previous value

            //i = 10;
            //A[i] = 1000;      //throws the exception error. Could be the case if using an if loop.

            int[] B = { 1, 2, 3, 4};

            Console.Write(B[0]);
            Console.Write(B[1]);
            Console.Write(B[2]);
            Console.Write(B[3]);

            Console.WriteLine();

            Console.Write(A[0]);
            Console.Write(A[1]);
            Console.Write(A[2]);

            Console.WriteLine();

            i = 4;
            int[] C = new int[i];   //C is an array of 4 int

            i = 5;                  //size of C doesn't change

            int[] D = new int[4];       //int[] D creates a reference to a new array of size 4 somewhere
            D = B;                      //this is not a copy operation...
            Console.WriteLine(D[2]);    //3
            D[2] = 300;
            Console.WriteLine(D[2]);    //300
            Console.WriteLine(B[2]);    //300

            int[] E;
            E = B;                      //this is not a copy operation... you're duplicating the reference to B.
            Console.WriteLine(E[2]);    //300
            E[2] = 200;
            Console.WriteLine(E[2]);    //200
            Console.WriteLine(B[2]);    //200

            //value datatypes: int, float, bool, double.., stored in STACK memory
            //reference datatypes: everything else <== these are pointers in C++, stored in HEAP memory
            //string is a reference datatype that can act as a value datatype

            //array.copy makes a copy of an existing array to be used for another. i.e. address/reference isn't duplicated

            Console.WriteLine();

            int[] F = new int[4];
            Array.Copy(B, F, B.Length);
            Console.WriteLine(F[1]);
            F[1] = 4000;
            Console.WriteLine(F[1]);
            Console.WriteLine(B[1]);

        }
    }
}
