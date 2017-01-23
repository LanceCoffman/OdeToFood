using OdeToFood.Entities;
using System.Collections.Generic;

//ViewModels for your views so they dont have to work that hard.
namespace OdeToFood.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
