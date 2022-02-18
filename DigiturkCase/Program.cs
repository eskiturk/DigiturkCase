using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(String[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int number1 = Convert.ToInt32(input[0]);
        int number2 = Convert.ToInt32(input[1]);
        int number3 = Convert.ToInt32(input[2]);

        input = Console.ReadLine().Split(' ');

        int[] array = new int[number1];

        for (int i = 0; i < number1; i++)
        {
            array[i] = Convert.ToInt32(input[i]);
        }

        for (int i = 0; i < number3; i++)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            int position = x - number2;

            while (position < 0)
            {
                position += number1;
            }

            Console.WriteLine(array[position]);
        }
    }
}