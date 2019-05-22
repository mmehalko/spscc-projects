using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HappierHarvest.Models
{
    public class Pumpkin
    {
        public string Color { get; set; }
        public string  Size { get; set; }
        public int Quantity { get; set; }
    }
    public class PumpkinDBContext : DbContext
    {
        public DbSet<Pumpkin> Pumpkins { get; set; }
    }
}