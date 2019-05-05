using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Windows95.Models
{
    public class CustomPrimaryDbContext : DbContext
    {
        public CustomPrimaryDbContext():base(SqlDatabaseConnection.GetConnectionString())
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties<int>().Where(property => property.Name == "PrimaryId").Configure(p => p.IsKey());
        }
    }
}