﻿internal class Program
{
    private static void Main(string[] args)
    {
        var lines = File.ReadLines(@"C:\Users\avidakovic\Desktop\keynotes.txt");

        var stacks = new List<Stack<char>>()
        {
            new Stack<char>(new[] { 'N', 'R', 'G', 'P'}),
            new Stack<char>(new[] { 'J', 'T', 'B', 'L', 'F', 'G', 'D', 'C' }),
            new Stack<char>(new[] { 'M', 'S', 'V' }),
            new Stack<char>(new[] { 'L', 'S', 'R', 'C', 'Z', 'P'}),
            new Stack<char>(new[] { 'P', 'S', 'L', 'V', 'C', 'W', 'D', 'Q' }),
            new Stack<char>(new[] { 'C', 'T', 'N', 'W', 'D', 'M', 'S' }),
            new Stack<char>(new[] { 'H', 'D', 'G', 'W', 'P' }),
            new Stack<char>(new[] { 'Z', 'L', 'P', 'H', 'S', 'C', 'M', 'V' }),
            new Stack<char>(new[] { 'R', 'P', 'F', 'L', 'W', 'G', 'Z' }),
        };

        foreach (var line in lines)
        {
            var splitLine = line.Split(' ');

            var n = int.Parse(splitLine[1]);
            var from = int.Parse(splitLine[3]);
            var to = int.Parse(splitLine[5]);

            var tempStack = new Stack<char>();

            while (n-- > 0)
            {
                tempStack.Push(stacks[from - 1].Pop());
            }

            while (tempStack.Count > 0)
            {
                stacks[to - 1].Push(tempStack.Pop());
            }
        }

        string result = "";
        result += (stacks[0].Pop());
        result += (stacks[1].Pop());
        result += (stacks[2].Pop());
        result += (stacks[3].Pop());
        result += (stacks[4].Pop());
        result += (stacks[5].Pop());
        result += (stacks[6].Pop());
        result += (stacks[7].Pop());
        result += (stacks[8].Pop());

        Console.WriteLine(result);
        Console.ReadLine();

    }
}