using DozenNetTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DozenNetTest.Domain.Contexts
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext() : base("connection")
        {
            Database.SetInitializer<ApplicationContext>(null);
        }

        public virtual DbSet<School> Schools { get; set; }
    }
}
