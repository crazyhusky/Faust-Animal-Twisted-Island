using System.Runtime.Remoting.Messaging;

namespace FATI_beta.Mechanics
{
    public class RPGDice
    {
        public static int D20()
        {
           return RandomNumbers.NumberBetween(0, 21);
        }

        public static int D5()
        {
            return RandomNumbers.NumberBetween(0, 6);
        }

        public static int D10()
        {
            return RandomNumbers.NumberBetween(0, 11);
        }
    }
}