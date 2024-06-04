namespace Assignment5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = 1;
            int number = GetNumberFromUser("Please enter a number.");
            GetNaturalNumbers(startNum, number);
        }

        static int GetNumberFromUser(string s)
        {
            string? userInput = "";

            do
            {
                Console.WriteLine(s);
                userInput = Console.ReadLine();
            } while (userInput == "");
            return Convert.ToInt32(userInput);
        }

        static void GetNaturalNumbers(int start, int end)
        {
            if (start <= end)
            {
                Console.Write($"{start} ");
                start++;
                GetNaturalNumbers(start, end);
            }
        }
    }
}
