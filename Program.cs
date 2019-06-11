using System;
using System.Linq;

namespace something
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            // string abc = pr.cp("abcdefgh");
            //int[] x = new int[] { 0, 1 };
            //int lo;
            //int xy = pr.ArrayMin(x, out lo);
            //Console.WriteLine(abc);

            int[] x = pr.sortarray();
            Console.WriteLine(string.Join(",", x));
            Console.Read();
            Console.WriteLine("Hello World!");
        }

        public string cp(string a)
        {
            char[] f;
            f = new char[a.Length];
            int index = 0;
            var array = a.ToCharArray();
            while(index < a.Length)
            {
                f[index] = array[index];
                index++;

            }

            string result = new string(f);
            return result;
        }


        public int ArrayMin(int[] arrayInput, out int loopCount)
        {

            int min = 0;
            loopCount = 0;

            for(int i=0;i<arrayInput.Length;i++)
            {
                if (i == 0) min = arrayInput[0];
                else if(arrayInput[i] < min)
                {
                    min = arrayInput[i];
                    loopCount++;
                }
            }


            return min;

            

        }


        public int[] sortarray()
        {
            int[] a = new int[] { 1, 2, 6 };
            int[] b = new int[] { 0, 3, 5 };
            int[] c = new int[] { 4, 7 };
            a.Length
            var xarray = a.Concat(b).Concat(c).OrderBy(x => x).ToArray();
            return xarray;
        }
    }
}
