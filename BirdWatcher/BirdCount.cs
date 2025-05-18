using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWatcher
{
    public class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay; 
        }


        public int[] LastWeek(int[] lastWeekCount)
        {
            Console.Write("[");
            for (int i = 0; i < lastWeekCount.Length; i++)
            {
                if(i <  lastWeekCount.Length - 1)
                {
                    Console.Write($"{lastWeekCount[i]}, ");
                }
                else
                {
                    Console.Write($"{lastWeekCount[i]}");
                }
            }
            Console.Write("]");
            Console.WriteLine();

            return lastWeekCount;           
        }

        public int Today()
        {
            int[] birdsPerDay = BirdsPerDay();

            Console.WriteLine(birdsPerDay[^1]);

            return birdsPerDay[^1];
        }

        public int IncrementTodaysCount()
        {
            int[] birdsPerDay = BirdsPerDay();

            birdsPerDay[^1] = birdsPerDay[^1] + 1;

            return birdsPerDay[^1];
        }

        public bool HasDayWithoutBirds()
        {
            int[] birdsPerDay = BirdsPerDay();

            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if(birdsPerDay [i] == 0)
                {
                    Console.WriteLine("true");
                    return true;
                }                      
            }

            Console.WriteLine("false");
            return false;
        }

        public int CountForFirstDays(int day)
        {
            int[] birdsPerDay = BirdsPerDay();

            int sum = 0;

            for(int i = 0;i < day; i++)
            {
                sum += birdsPerDay [i];
            }

            Console.WriteLine (sum);
            return sum;
        }

        public int BusyDays()
        {
            int[] birdsPerDay = BirdsPerDay();

            int counter = 0;

            for(int i = 0; i < birdsPerDay.Length; i++)
            {
                if(birdsPerDay[i] >= 5)
                {
                    counter++;
                } 
            }

            Console.WriteLine (counter);
            return counter;
        }

        public int[] BirdsPerDay()
        {
            BirdCount birdCount = new BirdCount(this.birdsPerDay);
            birdCount.birdsPerDay = this.birdsPerDay;

            return birdCount.birdsPerDay;
        }
    }
}
