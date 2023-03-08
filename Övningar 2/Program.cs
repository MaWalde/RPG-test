namespace Övningar_2
{
    internal class Program
    {
        public static List<int> rolls = new List<int>();
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hit enter to roll a d6!");
            Console.ReadKey();
            Console.WriteLine($"It lands on {Die6()}");*/
            /*Console.WriteLine("Ange antal d6 du vill rulla och ha totalen från: ");
            int ant = int.Parse(Console.ReadLine());
            Console.WriteLine($"Totalen av {ant} rullade d6 blev {SumD6(ant)}");*/

        }
        static int SumD6(int ant)
        {
            rolls.Clear();
            int sum = 0;
            for (int i = 0; i < ant; i++)
            {
                int roll = Die.D6();
                rolls.Add(roll);
                sum += roll;
            }
            return sum;
        }
    }
    class Die
    {
        public static int D4()
        {
            Random roll = new Random();
            int d4 = roll.Next(1, 5);
            return d4;
        }
        public static int D6()
        {
            Random roll = new Random();
            int d6 = roll.Next(1, 7);
            return d6;
        }
        public static int D8()
        {
            Random roll = new Random();
            int d8 = roll.Next(1, 9);
            return d8;
        }
        public static int D10()
        {
            Random roll = new Random();
            int d10 = roll.Next(1, 11);
            return d10;
        }
        public static int D12()
        {
            Random roll = new Random();
            int d12 = roll.Next(1, 13);
            return d12;
        }
        public static int D20()
        {
            Random roll = new Random();
            int d20 = roll.Next(1, 21);
            return d20;
        }
    }
}