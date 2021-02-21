using System;

namespace Day3Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //ref ile otureceyimiz deyiskeni evvelceden mutleq set etmeliyik
            int deyer1Ref = 17;
            int deyer2= 250;

            //out ile qeyd olunan zaman, biz evvelceden set etmesekde olar
            int deyer1Out;

            //int neticeRef = Topla(ref deyer1Ref,  deyer2Ref);
            int neticeOut = Topla(out deyer1Out, deyer2);

            //Console.WriteLine(neticeRef);

            //Console.WriteLine(neticeOut);

            //Console.WriteLine(deyer1Out);


            Console.WriteLine(Add(1, 7, 8, 10, 25, 47, 65));

        }

        public static int Topla(out int a, int b)
        {
            a = 10;
            return a + b;
        }

        //Params keyword example.
        public static int Add(params int[] values)
        {
            int netice = 0;

            for (int i = 0; i < values.Length; i++)
            {
                netice +=values[i];
            }
            return netice;
        }
    }

}
