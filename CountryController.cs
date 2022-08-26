namespace CountryMVCLab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("United States of America",
                Continent.NorthAmerica,
                new List<string>() {"Red", "White", "Blue"}),
            new Country("Italy",
                Continent.Europe,
                new List<string>() {"Red", "White", "Green"}),
            new Country("India",
                Continent.Asia,
                new List<string>() {"DarkYellow", "White", "Green", "Blue"}),
            new Country("Brazil",
                Continent.SouthAmerica,
                new List<string>() {"Green", "White", "Yellow", "Blue"}),
            new Country("Kenya",
                Continent.Africa,
                new List<string>() {"Red", "Green", "Black", "White"}),
        };

        public void CountryAction(Country c)
        {
            var view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            bool continueProgram = true;
            var view = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            while (continueProgram)
            {
                view.Display();
                Console.WriteLine($"\nWhich country would you like to view? Enter 1-{CountryDb.Count}");
                bool inputIsInt = int.TryParse(Console.ReadLine(), out int input);
                while (!inputIsInt || (input < 1 || input > CountryDb.Count))
                {
                    Console.WriteLine($"Please input a valid whole number between 1-{CountryDb.Count}");
                    inputIsInt = int.TryParse(Console.ReadLine(), out input);
                }
                CountryAction(CountryDb[input - 1]);
                Console.WriteLine("Would you like to look at the information for another country?\nPress 'Y' to continue or any other key to exit program");
                if(Console.ReadKey().Key != ConsoleKey.Y)
                    continueProgram = false;
            }
            Console.Clear();
            Console.WriteLine("Thank you for using our contry program!");
        }
    }
}
