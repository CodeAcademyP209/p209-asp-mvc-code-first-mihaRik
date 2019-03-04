using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RentACar.Models;

namespace RentACar.DAL
{
    public class RentACarContext : DbContext
    {
        public RentACarContext() :base("RentACarDb")
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}