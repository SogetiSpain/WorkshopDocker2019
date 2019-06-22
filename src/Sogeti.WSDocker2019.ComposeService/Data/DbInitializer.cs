namespace Sogeti.WSDocker2019.ComposeService.Data
{
    using Sogeti.WSDocker2019.ComposeService.Context;
    using Sogeti.WSDocker2019.ComposeService.Models;
    using System;
    using System.Linq;

    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Catalogs.Any())
            {
                return;   // DB has been seeded
            }

            var catalog = new Catalog[]
            {
                new Catalog{ Name="product1", Type ="Type1"},
                new Catalog{ Name="product2", Type ="Type2"},
                new Catalog{ Name="product3", Type ="Type3"},
                new Catalog{ Name="product4", Type ="Type4"},
                new Catalog{ Name="product5", Type ="Type5"}
            };

            context.Catalogs.AddRange(catalog);
           
            context.SaveChanges();
        }
    }
}
