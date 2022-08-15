using System;

namespace _02.From_Left_To_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();
                String[] inputSubStrings = input.Split();

                long leftNum = long.Parse(inputSubStrings[0]);
                long rightNum = long.Parse(inputSubStrings[1]);
                long biggerNum = Math.Max(leftNum, rightNum);

                char[] charArray = Math.Abs(biggerNum).ToString().ToCharArray();
                int sum = 0;

                for (int value = 0; value < charArray.Length; value++)
                {
                    sum += int.Parse(charArray[value].ToString());
                }
                Console.WriteLine(sum);
            }
          
        }
    }
}
