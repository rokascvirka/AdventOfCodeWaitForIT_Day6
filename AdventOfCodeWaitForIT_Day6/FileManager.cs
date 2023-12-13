using AdventOfCodeWaitForIT_Day6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeWaitForIT_Day6
{
    public class FileManager
    {
        public static List<RaceInformation> ReadFromFile(string filePath)
        {
            var raceInformation = new List<RaceInformation>();  
            List<int> time = new List<int>();
            List<int> distance = new List<int>();
            using(StreamReader sr = new StreamReader(filePath))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);  

                foreach (var line in text)
                {

                    var info = line.Split(":");

                    if (info[0].Contains("Time"))
                    {
                        var times = info[1].Split(' ').ToList();
                        times.RemoveAll(x => x == "");
                        var timesToInt = times.Select(x => int.Parse(x)).ToList();
                        time = timesToInt;
                    }
                    if (info[0].Contains("Distance"))
                    {
                        var distances = info[1].Split(' ').ToList();
                        distances.RemoveAll(x => x == "");
                        var distanceToInt = distances.Select(x => int.Parse(x)).ToList();
                        distance = distanceToInt;
                    }
                }
                long updatedTime = long.Parse(string.Join("", time));
                long updatedDistance = long.Parse(string.Join("", distance));
                for (int i = 0; i < time.Count; i++)
                {
                    raceInformation.Add(new RaceInformation(time[i], distance[i], updatedTime, updatedDistance));
                }
            }

            return raceInformation;
        }
    }
}
