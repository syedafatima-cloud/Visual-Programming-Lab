// File: CitiesRepository.cs
using System.Collections.Generic;

public static class CitiesRepository
{
    public static List<string> GetCities()
    {
        return new List<string>
        {
            "Lahore",
            "Karachi",
            "Islamabad",
            "Peshawar",
            "Quetta"
        };
    }
}
