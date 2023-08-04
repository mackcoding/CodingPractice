using Practice.Problems;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Debug.LineSplit();
            Debug.Write("Available Options - ");
            Debug.Write("1) Character Count");
            Debug.Write("2) Fizzbuzz");
            Debug.Write("3) Reverse String");
            Debug.Write("4) Anagram");
            Debug.Write("5) Anagram List");
            Debug.Write("6) Atoi");
            Debug.Write("7) Find hour based on hour hand angle");
            Debug.Write("8) Find angle between the hour/minute hands (h, m)");
            Debug.Write("9) ");
            Debug.Write("10) ");
            Debug.LineSplit();

            Console.Write("Select Option: ");
            var Key = Convert.ToInt32(Console.ReadLine());

            switch (Key)
            {
                case 1:
                    CharacterCount.Run();
                    break;
                case 2:
                    FizzBuzz.Run();
                    break;
                case 3:
                    StringReverse.Run();
                    break;
                case 4:
                    Anagram.Run();
                    break;
                case 5:
                    Anagram.SingleRun();
                    break;
                case 6:
                    Atoi.Run();
                    break;
                case 7:
                    HourHand.Run();
                    break;
                case 8:
                    HourHand.RunAngleToHour();
                    break;
                default:
                    Debug.Write("Invalid Command");
                    break;
            }

            Run();
        }
    }
}