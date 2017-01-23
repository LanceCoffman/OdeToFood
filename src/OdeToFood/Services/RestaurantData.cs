using OdeToFood.Interfaces;
using OdeToFood.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace OdeToFood.Services
{

    /// <summary>
    /// hold in memory with INMEMORY attribute
    /// </summary>
    public class InMemoryRestaurantData : IRestaurantData
    {
        //List - List collection is not thread safe
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
           {
                new Restaurant {Id =1, Name = "The Houes of Kobe" },
                new Restaurant {Id=2,Name="LJ's and the Kat" },
                new Restaurant {Id=3,Name="King's Contrivance" }

           };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        List<Restaurant> _restaurants;
    }
}
