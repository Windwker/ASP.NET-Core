using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    //public class InMemoryRestauranteData :IRestaurantData
    //{
    //    List<Restaurant> _restaurants;

    //    public InMemoryRestauranteData()
    //    {
            
    //        _restaurants = new List<Restaurant>();
    //        _restaurants.Add(new Restaurant { Id = 2, Name = "Overnight" });
    //        _restaurants.Add(new Restaurant { Id = 1, Name = "Restaurante Italiano" });
    //        _restaurants.Add(new Restaurant { Id = 3, Name = "Breach" });
    //        _restaurants.Add(new Restaurant { Id = 4, Name = "McDonalds" });
    //        _restaurants.Add(new Restaurant { Id = 5, Name = "Festo" });
    //    }

    //    public Restaurant Add(Restaurant newRestaurant)
    //    {
    //        newRestaurant.Id = _restaurants.Max(r => r.Id + 1);
    //        _restaurants.Add(newRestaurant);
    //        return newRestaurant;

    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
            


            
    //    }

    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(r=> r.Name);

    //    }
    //}
}
