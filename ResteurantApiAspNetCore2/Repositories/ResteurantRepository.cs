using ResteurantApiAspNetCore2.Entities;
using ResteurantApiAspNetCore2.Repositories.Interfaces;

namespace ResteurantApiAspNetCore2.Repositories
{
    public class ResteurantRepository : IResteurantRepository
    {
        private static readonly List<Resteurant> _resteurants = new List<Resteurant>()
        {
            new Resteurant()
            {
                Id = Guid.NewGuid(),
                Name= "Corleone",
                Description = "Best italian pizza",
                Category = "Fast Food",
                HasDelivery= true,
                ContactEmail = "corleonepizza@google.com",
                ContactNumber = "32167",
            }
        };

        //public async Task<List<Resteurant>> GetAll() => _resteurants;
        public async Task<List<Resteurant>> GetAll()
        {
            return _resteurants;
        }
    }

}
