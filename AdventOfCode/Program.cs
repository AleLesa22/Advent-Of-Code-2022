internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\avidakovic\Desktop\keynotes.txt");
        Console.WriteLine("Contents of Elfs.txt = ");

        int sum = 0;
        int max = int.MinValue;

        List<int> Elves = new List<int>();

        foreach (string line in lines)
        {
            Console.WriteLine("\t" + line);
            if (string.IsNullOrEmpty(line))
            {
                Elves.Add(sum);
                sum = 0;
            }
            else
            {
                sum += Convert.ToInt32(line);
            }
        }

        for (int i = 0; i < Elves.Count; i++)
        {
            if (Elves[i] > max)
            {
                max = Elves[i];
            }
        }
        Console.WriteLine(max);


        //SumOfTopThreeElves
        var sumOfTopThree = Elves.OrderByDescending(x => x).Take(3).Sum();
        Console.WriteLine("The sum of calories carried by the top three elves:");
        Console.WriteLine(sumOfTopThree);
        Console.ReadLine();
    }
}