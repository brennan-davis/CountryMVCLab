namespace CountryMVCLab
{
    public class Country
    {
        public Country(string name, Continent continentEnum, List<string> colors)
        {
            Name = name;
            ContinentEnum = continentEnum;
            Colors = colors;
        }
        
        public string Name { get; set; }

        public Continent ContinentEnum { get; set; }

        public List<string> Colors { get; set; }
    }
}
