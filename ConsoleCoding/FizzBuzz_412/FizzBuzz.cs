using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoding.FizzBuzz_412
{
    internal class FizzBuzz
    {
        public FizzBuzz() {
            Process(3);
        }
        public IList<string> Process(int n)
        {

            if (n == 1)
            {
                return new List<string>() { "1" };
            }
            else if (n == 2)
            {
                return new List<string>() { "1", "2" };

            }
            else if (n == 3)
            {
                return new List<string>() { "1", "2", "Fizz" };
            }
            else if (n == 4)
            {
                return new List<string>() { "1", "2", "Fizz", "4" };
            }
            else if (n == 5)
            {
                return new List<string>() { "1", "2", "Fizz", "4", "Buzz" };
            }
            else
            {
                IList<string> ar = new List<string>();
                for (int i = 1; i < n + 1; i++)
                {
                    int v1 = i % 3;
                    int v2 = i % 5;

                    if (v1 == 0 && (v2 == 0))
                    {
                        ar.Add("FizzBuzz");

                    }
                    else if (v2 == 0)
                    {
                        ar.Add("Buzz");

                    }
                    else if (v1 == 0)
                    {
                        ar.Add("Fizz");

                    }
                    else
                    {
                        ar.Add(i.ToString());

                    }

                }
                PR(ar);
                return ar;
            }
        }
        public IList<string> Process2(int n)
        {
            IList<string> ar = new List<string>();

            int n3 = n / 3;
            int n5 = n / 5;
            Dictionary<int, string> dict = new Dictionary<int, string>();

            for (int i = 1; i < n+1; i++)
            {
                int v1 = i % 3;
                int v2 = i % 5;

                if (v1 == 0 && (v2 == 0))
                {
                    dict.Add(i, "FizzBuzz");
                }
                else if (v2== 0)
                {
                    dict.Add(i, "Buzz");
                }
                else if (v1 == 0)
                {
                    dict.Add(i, "Fizz");
                }
                else
                {
                    dict.Add(i,i.ToString());
                }
            }
 
            for (int i = 1; i < n + 1; i++)
            {
                if (dict.Keys.Contains(i))
                {
                    ar.Add(dict[i]);
                }
                else
                {
                    ar.Add(i.ToString());
                }
            }
            PR(ar);
            return ar;
        }
    
        public IList<string> Process1(int n)
        {
            IList<string> ar = new List<string>();

            int n3 = n / 3;
            int n5 = n / 5;
            Dictionary<int, string> dict = new Dictionary<int, string>();

            for (int i = 0; i < n3 + 1; i++)
            {
                int v = (i + 1) * 3;
                if (v % 3 == 0 && (v % 5 == 0))
                {
                    dict.Add(v, "FizzBuzz");
                }
                else if (v % 5 == 0)
                {
                    dict.Add(v, "Buzz");
                }
                else if (v % 3 == 0)
                {
                    dict.Add(v, "Fizz");
                }
            }
            for (int i = 0; i < n5 + 1; i++)
            {
                int v = (i + 1) * 5;
                if (v % 5 == 0)
                {
                    if (dict.Keys.Contains(v))
                    {
                        dict[v] = "FizzBuzz";
                    }
                    else
                    {
                        dict.Add(v, "Buzz");
                    }
                    
                }
                
            }
            
            for (int i = 1; i < n + 1; i++)
            {
                if (dict.Keys.Contains(i))
                {
                    ar.Add(dict[i]);
                }
                else
                {
                    ar.Add(i.ToString());
                }
            }
            PR(ar);
            return ar;
        }
        public IList<string> Process0(int n)
        {
            IList<string> ar = new List<string>();

            int n3 = n / 3;
            int n5 = n / 5;
            int[] ar3 = new int[n3];
            int[] ar5 = new int[n5];
            for (int i = 0; i < n3; i++)
            {
                ar3[i] = (i + 1) * 3;
            }
            for (int i = 0; i < n5; i++)
            {
                ar5[i] = (i + 1) * 5;
            }
            for (int i = 1; i < n + 1; i++)
            {
                if (ar3.Contains(i) && ar5.Contains(i))
                {
                    ar.Add("FizzBuzz");
                }
                else if (ar5.Contains(i))
                {
                    ar.Add("Buzz");
                }
                else if (ar3.Contains(i))
                {
                    ar.Add("Fizz");
                }
                else
                {
                    ar.Add(i.ToString());
                }
            }
            PR(ar);
            return ar;
        }
        private void PR(IList<string> ar)
        {
            foreach(string s in ar)
            {
                System.Diagnostics.Debug.WriteLine(s);
            }
        }
    }
}
