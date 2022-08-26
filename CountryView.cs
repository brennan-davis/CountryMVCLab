using System.Drawing;

namespace CountryMVCLab
{
    public class CountryView
    {
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public Country DisplayCountry { get; set; }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("COUNTRY DETAILS\n---------------");
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.ContinentEnum}");
            Console.WriteLine("Flag Colors:");
            foreach(var color in DisplayCountry.Colors)
            {
                Console.Write("  -");
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                if(Console.ForegroundColor == ConsoleColor.Black)
                    Console.BackgroundColor = ConsoleColor.White;
                Console.Write($" {color}");
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.WriteLine();

        }
    }
}
