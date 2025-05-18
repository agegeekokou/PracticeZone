using AnnalynInfiltration;
using BirdWatcher;
using SqueakyClean;
using System;
using System.Text;

namespace PracticeZone.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int[] lastWeekCount = { 0, 2, 5, 3, 7, 8, 4 };
            //BirdCount birdCount = new BirdCount(lastWeekCount);
            //birdCount.LastWeek(lastWeekCount);

            //int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            //birdCount = new BirdCount(birdsPerDay);

            //birdCount.IncrementTodaysCount();
            //birdCount.Today();
            //birdCount.HasDayWithoutBirds();
            //birdCount.CountForFirstDays(4);
            //birdCount.BusyDays();

            //var knightIsAwake = true;
            //QuestLogic.CanFastAttack(knightIsAwake);

            //knightIsAwake = false;
            //var archerIsAwake = false;
            //var prisonerIsAwake = true;
            //QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);

            //archerIsAwake = false;
            //prisonerIsAwake = true;
            //QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);

            //knightIsAwake = false;
            //archerIsAwake = false;
            //prisonerIsAwake = false;
            //var petDogIsPresent = false;
            //QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);

            //Identifier.Clean("1😀2😀3😀 this is a letter !");

            Identifier.Clean("abcΑΒΓ123δεζ");
            //Console.WriteLine(result); // should output: "thisisaletter"


            //StringBuilder sb = new StringBuilder("hello-world");
            ////sb.Insert(5, " CTRL");
            ////sb.Replace("\0", "CTRL");
            //sb.Remove(6, 1);    
            ////sb.AppendLine(" How are you doing ?");
            ////sb.AppendLine("Hello Tom!");
            //Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
