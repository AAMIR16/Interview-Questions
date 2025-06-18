using System;

namespace MeetingRooms1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = new int[][] { };
            input[0] = new int[] { 5, 10 };
            input[1] = new int[] { 0, 30 };
            input[2] = new int[] { 15, 20 };

            var result = CanAttendMeetings(input);
            Console.WriteLine(result);

        }
        public static bool CanAttendMeetings(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals == null)
                return true;

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            //access the firstInterval
            var firstInterval = intervals[0];

            //compare the first interval with the next until the last interval is achieved.
            for(int i = 1; i< intervals.Length; i++)
            {
                //Check if the start time of next interval is before the end time of previous interval

                if (intervals[i][0] < firstInterval[1])
                {
                    return false;
                }
                else
                    firstInterval = intervals[i];
            }
            
            return true;
        }
    }
}
