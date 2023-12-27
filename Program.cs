using System.ComponentModel.Design;

namespace BinaryClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti ora curenta (HH:mm:ss):");
            string input = Console.ReadLine();

            if (IsValidTimeFormat(input))
            {
                string[] timeParts = input.Split(':');
                int hours = int.Parse(timeParts[0]);
                int minutes = int.Parse(timeParts[1]);
                int seconds = int.Parse(timeParts[2]);

                string binaryHours = Convert.ToString(hours, 2).PadLeft(5, '0');
                string binaryMinutes = Convert.ToString(minutes, 2).PadLeft(6, '0');
                string binarySeconds = Convert.ToString(seconds, 2).PadLeft(6, '0');

                Console.WriteLine($"Ceasul binar este: {binaryHours}:{binaryMinutes}:{binarySeconds}");



            }
            else
            {
                Console.WriteLine("Format dfe tip invalid. Introduceti ora in formatul HH:mm:ss.");

            }
        }
        static bool IsValidTimeFormat(string input)
        {
            string[] timeParts = input.Split(":");
            if (timeParts.Length == 3)
            {
                if (int.TryParse(timeParts[0], out int hours) &&
                        int.TryParse(timeParts[1], out int minutes) &&
                        int.TryParse(timeParts[2], out int seconds)) {
                    return hours >= 0 && hours < 24 &&
                           minutes >= 0 && minutes < 60 &&
                           seconds >= 0 && seconds < 60;
                }

            }
            return false;
        }
    }
}