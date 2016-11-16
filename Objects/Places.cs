using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    private string _cityName;
    private string _description;
    private string _rating;
    private int _id;
    private static List<Place> _places = new List<Place> {};

    public Place(string cityName, string description, string rating)
    {
      _cityName = cityName;
      _description = description;
      _rating = rating;

      _places.Add(this);
      _id = _places.Count;
    }
    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetRating()
    {
      return _rating;
    }
    public void SetRating(string newRating)
    {
      _rating = newRating;
    }
    public static List<Place> GetAll()
    {
      return _places;
    }
    public static void ClearAll()
    {
      _places.Clear();
    }
    public static Place Find(int searchID)
    {
      return _places[searchID - 1];
    }
    public int GetID()
    {
      return _id;
    }
  }
}
