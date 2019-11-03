using System;

namespace dotNet5780_01_4758_7791
{
    public class Part_1
    {
        int[] A;
        int[] B;
        int[] C;
        public Part_1()
        {
            A = new int[20];
            B = new int[20];
            C = new int[20];

        }

        public void hagrel(Random r)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(18, 122);
                B[i] = r.Next(18, 122);
                C[i] = Math.Abs( A[i] - B[i]);
            }
        }

        public void showResults()
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0,3} ", A[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("{0,3} ", B[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write("{0,3} ", C[i]);

            }
            Console.WriteLine();
        }
    }
}