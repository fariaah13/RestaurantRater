using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {

        //database table will have these fields
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class RestaurantDbContext : DbContext
    {
        //This is what we update and add to and save
        //This is our table so the name can be plural
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}