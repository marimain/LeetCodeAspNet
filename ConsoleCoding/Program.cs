using ConsoleCoding.AddTwoNumber_002;
using ConsoleCoding.FindNWord_1160;
using ConsoleCoding.FizzBuzz_412;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddTwoNumbercs c=new AddTwoNumbercs();
            FizzBuzz oFizzBuzz = new FizzBuzz();
        }
        static void Main_back(string[] args)
        {
           
            Dictionary<int, int> ag = new Dictionary<int, int>();
            ag.Add(1, 3);
            ag.Add(2, 1);
            ag.Add(3, 1);
            ag.Add(4, 2);
            
            for (int i = 0; i < ag.Count; i++)
            {

            }

            /*
            double a = 1 / (double)561;
            int k = 36;
            bool isok = false;
            //int[] ints = { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 45, 48, 78, 89, 90, 97, 98 };
            int[] ints = { 1, 2, 3, 4, 5, 7, 8, 9, 10,11,13 };
            //int[] ints = { };
            if (ints.Length == 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 1:
                            k = 6;
                            break;
                        case 2:
                            k = 9;
                            break;
                        case 3:
                            k = 3;
                            break;
                    }

                    if (ints[0] == k || ints[ints.Length - 1] == k)
                    {
                        isok = true;
                    }
                    else
                    {
                        isok = checkhalf(ints, k);
                    }
                    Console.WriteLine("K =" + k.ToString());
                    Console.WriteLine(isok);
                }
            }
        */
            Console.ReadLine();
        }
        private static bool checkhalf(int[] ar, int k)
        {
            bool ret = false;
            int cnt = ar.Length;
            bool even = cnt % 2 == 0 ? true : false;
            
            int cnthalf = even == true ? cnt / 2 : cnt / 2 + 1;     //second half has one more item
            int vh = even == true ? ar[cnt / 2] : ar[cnt / 2]; //first # of second half
            int ubound = 0;
            int lbound = ar.Length-1;
            if (vh == k)
            {
                return true;
            }

            if (vh > k) // get the top part
            {
                int[] ar2 = new int[cnt / 2];
                Array.Copy(ar, 0, ar2, 0, cnt / 2);
                ar2[0] = 100;
                ar[1] = 101;
                if (ar2.Length == 1)
                {
                    if (ar2[0] == k)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                ret = checkhalf(ar2, k);
            }
            if (vh < k) //get the second part,  odd array has one more than first set
            {
                int[] ar2 = new int[cnthalf];
                Array.Copy(ar, cnt/2, ar2, 0, cnthalf);
                if (ar2.Length == 1)
                {
                    if (ar2[0] == k)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                ret =checkhalf(ar2, k);
            }
            return ret;
        }
            
    }
}