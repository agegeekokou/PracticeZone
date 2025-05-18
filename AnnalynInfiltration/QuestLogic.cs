namespace AnnalynInfiltration
{
    public class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if(knightIsAwake)
            {
                Console.WriteLine("false");
                return false;
            }

            Console.WriteLine("true");
            return true;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if(knightIsAwake || archerIsAwake || prisonerIsAwake)
            {
                Console.WriteLine("true");
                return true;
            }
            else if(!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
            {
                Console.WriteLine("false");
                return false;
            }

            return false;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if(!archerIsAwake && prisonerIsAwake)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, 
            bool prisonerIsAwake, bool petDogIsPresent)
        {
            if((petDogIsPresent && !archerIsAwake && knightIsAwake && prisonerIsAwake)
                || (!petDogIsPresent && !archerIsAwake && !knightIsAwake && prisonerIsAwake))
            {
                Console.WriteLine("true");
                return true;
            }
            else if(!petDogIsPresent && !archerIsAwake && !knightIsAwake && !prisonerIsAwake)
            {
                Console.WriteLine("false");
                return false;
            }

            Console.WriteLine("false");
            return false;
        }
    }
}
