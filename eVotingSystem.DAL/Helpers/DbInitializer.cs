
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.EF;
using eVotingSystem.DAL.Helpers;
using Microsoft.Extensions.DependencyInjection;


namespace eVotingSystem.DAL.Helpers
{
    public class DbInitializer
    {
        public static void Seed(ServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<eVotingSystemDbContext>();

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            #region Countries
            dbContext.Countries.Add(new Country { Name = "Bosna i Hercegovina" });
            dbContext.Countries.Add(new Country { Name = "Germany" });
            dbContext.Countries.Add(new Country { Name = "United States Of America" });

            dbContext.SaveChanges();
            #endregion

            #region Cities
            dbContext.Cities.Add(new City { Name = "Mostar", CountryId = 1 });
            dbContext.Cities.Add(new City { Name = "Frankfurt", CountryId = 2 });
            dbContext.Cities.Add(new City { Name = "New York", CountryId = 3 });

            dbContext.SaveChanges();
            #endregion

            var salt = Crypto.GenerateSalt();


        }
    }
}
