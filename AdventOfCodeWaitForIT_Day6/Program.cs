using System.Reflection;

namespace AdventOfCodeWaitForIT_Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "Input_Day6.txt");

            var data = FileManager.ReadFromFile(FILE_PATH);
            long possibilities = 1;
            long updatedPossibilities = 1;
            foreach (var item in data)
            {
                possibilities = (long)possibilities * (long)item.PossibleWinsCount;
            }
            Console.WriteLine($"Possibilities: {possibilities},  updated: {data[1].UpdatedPossibleWinsCount}");
        }
    }
}