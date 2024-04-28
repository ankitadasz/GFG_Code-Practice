//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                

                int n = Convert.ToInt32(Console.ReadLine());
                Solution obj = new Solution();
                long res = obj.seriesSum(n);
                Console.Write(res+"\n");
            }

        }
    }
}

// } Driver Code Ends


//User function template for C#
class Solution
{
    // function to return sum of 1, 2, ... n
    public long seriesSum(int n)
    {
       long sum=((long) n)*((long) n + 1) / 2;
        return sum;
    }
}