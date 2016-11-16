using Nancy;
using System.Collections.Generic;
using Places.Objects;

namespace Places //replace with your desired namespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/places/new"] = _ => View["place_form.cshtml"];
      Get["/places"] = _ =>
      {
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Post["/places"] = _ =>
      {
        Place newPlace = new Place(Request.Form["cityName"], Request.Form["description"], Request.Form["rating"]);
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/{id}"] = parameters =>
      {
        Place currentPlace = Place.Find(parameters.id);
        return View["place.cshtml", currentPlace];
      };
    }
  }
}
