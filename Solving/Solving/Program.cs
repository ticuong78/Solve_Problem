using System.Collections.Generic;

namespace Solving
{
    internal class Program
    {
        static int[] GetInput()
        {
            string[] inputString = Console.ReadLine().Split();
            int n = inputString.Length;
            int[] inputNum = new int[n];
            for(int i = 0; i < n; i++)
            {
                inputNum[i] = Convert.ToInt32(inputString[i]);
            }

            return inputNum;
        }

        static void PutValue(int[] refArray, int value_1, int value_2)
        {
            if (refArray[value_1 - 1] == 0) refArray[value_1 - 1] = value_2 - 1;
            else refArray[value_1 - 1] = refArray[value_2 - 1];
        }

        static void DisplayArray(int[] refArray)
        {
            for(int i = 0; i < refArray.Length; i++)
            {
                Console.WriteLine("{0}: {1} ", i, refArray[i]);
            }
        }

        static void Process(int[] refArray, int n)
        {
            for(int i = 0; i < n; i++)
            {
                int[] param = GetInput();
                PutValue(refArray, param[0], param[1]);
            }
            DisplayArray(refArray);
        }

        static void Main(string[] args) 
        {
            int[] meta = GetInput();
            int[] refArray = new int[meta[0]];
            Process(refArray, meta[1]);
        }
    }
}
