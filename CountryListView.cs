namespace CountryMVCLab
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public List<Country> Countries { get; set; }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Countries:");
            int count = 0;
            Countries.ForEach(c => Console.WriteLine($"{++count}. {c.Name} - {c.ContinentEnum}"));
        }
    }
}
