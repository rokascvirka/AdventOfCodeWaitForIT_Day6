using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeWaitForIT_Day6.Models
{
    public class RaceInformation
    {
        public int Time { get; set; }
        public int CurrentRecordDistance { get; set; }
        public long PossibleWinsCount { get; set; }

        public long UpdatedTime {  get; set; }
        public long UpdatedRecordDistance { get; set; }

        public long UpdatedPossibleWinsCount {  get; set; }

        public RaceInformation(int time, int currentRecord, long upadatedTime, long upadtedDistance)
        {
            Time = time;
            CurrentRecordDistance = currentRecord;
            UpdatedTime = upadatedTime;
            UpdatedRecordDistance = upadtedDistance;
            PossibleWinsCount = CountPossibleWins(time, currentRecord);
            UpdatedPossibleWinsCount = CountPossibleWins(upadatedTime, upadtedDistance);

        }

        private long CountPossibleWins(long time, long currentRecord) 
        {
            long count = 0;
            for (int i = 1; i <= time; i++)
            {
                var hold = i;
                var timeLeft = time - hold;
                var distanceTraveled = i * timeLeft;
                if(timeLeft > 0 && distanceTraveled > currentRecord)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
