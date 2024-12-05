using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programming_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int t = Convert.ToInt32(input[0]);
            int s = Convert.ToInt32(input[1]);
            int[,] stopped = new int[t,s];
            int[] allStopped = new int[s];

            for (int i = 0; i < t; i++) {
            
                input = Console.ReadLine().Split(' ');

                for (int j = 0; j < s; j++) {

                    stopped[i,j] = Convert.ToInt32(input[j]);
                
                }

            }

            for (int i = 0; i < s; i++)
            {

                int j = 0;
                int count = 0;

                while (j < t && stopped[j, i] != 0) {
                    count += 1;
                    j += 1;
                }

                if (count == t)
                {
                    allStopped[i] = 1;
                }
                else {
                    allStopped[i] = 0;
                }


            }

            

            for (int i = 0; i < s; i++)
            {
                if (i == 0) {
                    Console.Write("{0}", allStopped[i]);
                }
                else {
                    Console.Write(" {0}", allStopped[i]);
                }
                      
            }

            Console.ReadLine();


        }
    }
}
