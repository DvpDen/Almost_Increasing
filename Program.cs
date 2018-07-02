using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almost_Increasing
{
    class Program
    {
        public static bool almostIncreasingSequence(int[] sequence)
        {
            int size = sequence.Length;
            int x = 0, remove = 0;
            int[] newarray = { };

            for (x = 0; x < size; x++) {
                if (sequence[x + 1] <= sequence[x]){
                    remove++;
                    for (int t = x+1; t < size -1; t++){
                        sequence[t] = sequence[t+1]; 
                    }
                    size--;
                    Console.Write("\nsize: " + size);   
                }  
            }

            for (int i = 0; i < size; i++)
                Console.Write(sequence[i]);

            if (remove == 1)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int[] sequence = { 0, -2, 5, 6 };
            Console.Write(almostIncreasingSequence(sequence));
            Console.ReadLine();
        }
    }
}
