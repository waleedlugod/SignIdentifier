using System;

namespace SignIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand;
            int negativeCount = 0;

            for (int i = 1; i < 3; i++)
            {
                string ordinal = "th";
                if (i == 3)
                {
                    ordinal = "rd";
                }
                else if (i == 2)
                {
                    ordinal = "nd";
                }
                else if (i == 1)
                {
                    ordinal = "st";
                }

                Console.WriteLine("Enter " + i + ordinal + " value: ");
                operand = double.Parse(Console.ReadLine());

                if (operand < 0)
                {
                    negativeCount++;
                }
            }

            Console.WriteLine("The sign of the answer is {0}", (negativeCount % 2 == 0) ? "positive." : "negative.");
        }
    }
}
