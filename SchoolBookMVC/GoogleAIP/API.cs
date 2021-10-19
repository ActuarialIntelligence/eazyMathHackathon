using Newtonsoft.Json;
using System.Net.Http;

namespace SchoolBookMVC.GoogleAIP
{
    public class API
    {
        public static PlacesApiQueryResponse GetPlaces(Location location)
        {//AIzaSyBqgPnTfSLO537bnsvYIIRJSVkXW9_S9RE
            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync(
                    string.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=500&type=school&key=AIzaSyBqgPnTfSLO537bnsvYIIRJSVkXW9_S9RE", location.lat, location.lng))
                    .Result;
                var result = JsonConvert.DeserializeObject<PlacesApiQueryResponse>(response);
                return result;
            }
        }
    }
}