namespace MinimalOwinWebApiSelfHost
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OwinDB : DbContext
    {
        public OwinDB()
            : base("name=OwinDB")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
