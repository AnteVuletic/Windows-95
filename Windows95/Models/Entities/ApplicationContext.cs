using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Windows95.Models.Entities
{
    public class ApplicationContext : CustomPrimaryDbContext
    {
        public DbSet<Application> Applications { get; set; }
    }
}