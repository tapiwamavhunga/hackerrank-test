using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        int q = Convert.ToInt32(tokens_n[2]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int[] b = new int[n];
        for (int i = 0; i < n; i++) { b[i] = a[i]; }
        k = k % n; int tmp;
        for (int i = 0; i < n; i++)
        {
            tmp = (i + n - k) % n;
            a[i] = b[tmp];
        }
        for (int a0 = 0; a0 < q; a0++)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a[m]);
        }
    }
}