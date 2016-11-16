using System.Collections.Generic;

namespace Place.Objects
{
  public class Place
  {
    private string _cityName;

    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }
  }
}
