using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace VisualStudioLaunchyThing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            var solutionFiles = Directory
                .EnumerateFiles(path, "*.sln")
                .ToArray();

            var selectedSolution = "";
            if (solutionFiles.Length == 0)
            {
                Console.WriteLine("No solutions found");
                return;
            }
            else if (solutionFiles.Length == 1)
            {
                selectedSolution = solutionFiles.Single();
            }
            else
            {
                for (var i = 0; i < solutionFiles.Length; i ++)
                {
                    Console.WriteLine("[{0}]: {1}", i + 1, solutionFiles[i]);
                }
                Console.Write("Solution [1]: ");
                var input = Console.ReadLine().Trim();
                if (input == string.Empty)
                {
                    selectedSolution = solutionFiles[0];
                }
                else
                {
                    try
                    {
                        var index = int.Parse(input);
                        selectedSolution = solutionFiles[index];
                    }
                    catch
                    {
                        Console.WriteLine("Invalid solution");
                        return;
                    }
                }
            }

            Console.WriteLine("Opening solution {0}...", selectedSolution);
            Process.Start(selectedSolution);
        }
    }
}
