namespace Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int numMin;
            int numMax;
            for (numMin = 1, numMax = 0; numMin >= numMax;)
            {
                Console.Write("Pick a minimum number: ");
                numMin = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pick a maximum number: ");
                numMax = Convert.ToInt32(Console.ReadLine());
                if (numMin > numMax)
                {
                    Console.WriteLine("The minimum is bigger than the maximum. Try again!");
                    Console.WriteLine();
                }
                else if (numMin == numMax)
                {
                    Console.WriteLine("The minimum is equal to the maximum. Try again!");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            for (int loop1 = 1; loop1 <= 5; loop1++)
            {
                int numRandom1 = generator.Next(numMin, numMax + 1);
                Console.Write(numRandom1 + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int sumDice = 0;
            Console.WriteLine("how many dice do you want to roll? : ");
            int numDice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int loop2 = numDice; loop2 >= 1; loop2--)
            {
                int numRandom2 = generator.Next(1, 7);
                Console.Write(numRandom2 + " ");
                sumDice += numRandom2;
            }
            Console.WriteLine() ;
            Console.WriteLine("The sum of the dice is, " + sumDice);
            Console.WriteLine();

            Console.WriteLine("We will find a random number with decimals, feel free to use decimals while declaring your min and max.");
            Console.WriteLine();
            double numMin2, numMax2;
            for (numMin2 = 1, numMax2 = 0; numMin2 >= numMax2;)
            {
                Console.Write("Pick a minimum number: ");
                numMin2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Pick a maximum number: ");
                numMax2 = Convert.ToDouble(Console.ReadLine());
                if (numMin2 > numMax2)
                {
                    Console.WriteLine("The minimum is bigger than the maximum. Try again!");
                    Console.WriteLine();
                }
                else if (numMin2 == numMax2)
                {
                    Console.WriteLine("The minimum is equal to the maximum. Try again!");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine(generator.NextDouble() * (numMax2 - numMin2) + numMin2);
            Console.WriteLine();
        }
    }
}