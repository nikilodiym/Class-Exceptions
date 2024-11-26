namespace Class_Exceptions
{
    internal class Program
    {
        public class City
        {
            private string cityName;
            private string countryName;
            private int population;
            private string areaCode;
            private string[] districts;

            public void SetCityName(string name)
            {
                cityName = name;
            }

            public string GetCityName()
            {
                return cityName;
            }

            public void SetCountryName(string name)
            {
                countryName = name;
            }

            public string GetCountryName()
            {
                return countryName;
            }

            public void SetPopulation(int count)
            {
                population = count;
            }

            public int GetPopulation()
            {
                return population;
            }

            public void SetAreaCode(string code)
            {
                areaCode = code;
            }

            public string GetAreaCode()
            {
                return areaCode;
            }

            public void SetDistricts(string[] districts)
            {
                this.districts = districts;
            }

            public string[] GetDistricts()
            {
                return districts;
            }

            public void DisplayCityInfo()
            {
                Console.WriteLine("City Name: " + cityName);
                Console.WriteLine("Country Name: " + countryName);
                Console.WriteLine("Population: " + population);
                Console.WriteLine("Area Code: " + areaCode);
                Console.WriteLine("Districts: " + string.Join(", ", districts));
            }
        }

    }
}
