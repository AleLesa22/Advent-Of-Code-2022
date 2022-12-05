﻿internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\avidakovic\Desktop\keynotes.txt");

        //Stack 1
        Stack<char> Stack1 = new Stack<char>();
        Stack1.Push('N');
        Stack1.Push('R');
        Stack1.Push('G');
        Stack1.Push('P');

        //Stack 2
        Stack<char> Stack2 = new Stack<char>();
        Stack2.Push('J');
        Stack2.Push('T');
        Stack2.Push('B');
        Stack2.Push('L');
        Stack2.Push('F');
        Stack2.Push('G');
        Stack2.Push('D');
        Stack2.Push('C');

        //Stack 3
        Stack<char> Stack3 = new Stack<char>();
        Stack3.Push('M');
        Stack3.Push('S');
        Stack3.Push('V');

        //Stack 4
        Stack<char> Stack4 = new Stack<char>();
        Stack4.Push('L');
        Stack4.Push('S');
        Stack4.Push('R');
        Stack4.Push('C');
        Stack4.Push('Z');
        Stack4.Push('P');

        //Stack 5
        Stack<char> Stack5 = new Stack<char>();
        Stack5.Push('P');
        Stack5.Push('S');
        Stack5.Push('L');
        Stack5.Push('V');
        Stack5.Push('C');
        Stack5.Push('W');
        Stack5.Push('D');
        Stack5.Push('Q');


        //Stack 6
        Stack<char> Stack6 = new Stack<char>();
        Stack6.Push('C');
        Stack6.Push('T');
        Stack6.Push('N');
        Stack6.Push('W');
        Stack6.Push('D');
        Stack6.Push('M');
        Stack6.Push('S');

        //Stack 7
        Stack<char> Stack7 = new Stack<char>();
        Stack7.Push('H');
        Stack7.Push('D');
        Stack7.Push('G');
        Stack7.Push('W');
        Stack7.Push('P');

        //Stack 8
        Stack<char> Stack8 = new Stack<char>();
        Stack8.Push('Z');
        Stack8.Push('L');
        Stack8.Push('P');
        Stack8.Push('H');
        Stack8.Push('S');
        Stack8.Push('C');
        Stack8.Push('M');
        Stack8.Push('V');


        //Stack 9
        Stack<char> Stack9 = new Stack<char>();
        Stack9.Push('R');
        Stack9.Push('P');
        Stack9.Push('F');
        Stack9.Push('L');
        Stack9.Push('W');
        Stack9.Push('G');
        Stack9.Push('Z');


        foreach (string line in lines)
        {
            var move = line.Split("from")[0];
            var toWhere = line.Split("from")[1];

            var valueToMove = int.Parse(move.Split("move ")[1]);
            var valueFrom = int.Parse(toWhere.Split(" to ")[0]);
            var valueTo = int.Parse(toWhere.Split(" to ")[1]);

            for (int i = 0; i < valueToMove; i++)
            {
                if (valueFrom == 1)
                {
                    var x = Stack1.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 2)
                {
                    var x = Stack2.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 3)
                {
                    var x = Stack3.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 4)
                {
                    var x = Stack4.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 5)
                {
                    var x = Stack5.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 6)
                {
                    var x = Stack6.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 7)
                {
                    var x = Stack7.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 8)
                {
                    var x = Stack8.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
                else if (valueFrom == 9)
                {
                    var x = Stack9.Pop();
                    if (valueTo == 1)
                    {
                        Stack1.Push(x);
                    }
                    else if (valueTo == 2)
                    {
                        Stack2.Push(x);
                    }
                    else if (valueTo == 3)
                    {
                        Stack3.Push(x);
                    }
                    else if (valueTo == 4)
                    {
                        Stack4.Push(x);
                    }
                    else if (valueTo == 5)
                    {
                        Stack5.Push(x);
                    }
                    else if (valueTo == 6)
                    {
                        Stack6.Push(x);
                    }
                    else if (valueTo == 7)
                    {
                        Stack7.Push(x);
                    }
                    else if (valueTo == 8)
                    {
                        Stack8.Push(x);
                    }
                    else if (valueTo == 9)
                    {
                        Stack9.Push(x);
                    }
                }
            }
        }

        string result = "";
        result += (Stack1.Pop());
        result += (Stack2.Pop());
        result += (Stack3.Pop());
        result += (Stack4.Pop());
        result += (Stack5.Pop());
        result += (Stack6.Pop());
        result += (Stack7.Pop());
        result += (Stack8.Pop());
        result += (Stack9.Pop());

        Console.WriteLine(result);
        Console.ReadLine();
    }
}