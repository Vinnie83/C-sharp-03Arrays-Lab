namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool areNotIdentical = false;


            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    areNotIdentical = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

                int currentNumber = numbers1[i];
                sum += currentNumber;

            }

            if (!areNotIdentical)
            {

                Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }

        }
    }
}