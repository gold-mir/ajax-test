using System;

namespace Test.Models
{
    public static class Helper
    {
        private static Random rand = new Random();
        public static int GetRandomNumber()
        {
            return rand.Next(1, 7);
        }

        public static int HeckCount = 0;
        public static void GiveSomeHecks(int number)
        {
            HeckCount += number;
        }
    }
}
