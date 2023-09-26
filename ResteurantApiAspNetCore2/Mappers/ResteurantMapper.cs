using ResteurantApiAspNetCore2.DTOs;
using ResteurantApiAspNetCore2.Entities;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace ResteurantApiAspNetCore2.Mappers
{
    public class ResteurantMapper
    {
        public static Resteurant MapFrom(ResteurantDto resteurantDto)
        {
            var result = new Resteurant()
            {
                Id = new Guid(),
                Name = resteurantDto.Name,
                Description = resteurantDto.Description,
                Category = resteurantDto.Category,
                HasDelivery = resteurantDto.HasDelivery,
                ContactEmail = resteurantDto.ContactEmail,
                ContactNumber = resteurantDto.ContactNumber,
            };

            return result;
        }

        public static ResteurantDto MapFrom(Resteurant resteurant)
        {
            var result = new ResteurantDto()
            {
                Name = resteurant.Name,
                Description = resteurant.Description,
                Category = resteurant.Category,
                HasDelivery = resteurant.HasDelivery,
                ContactEmail = resteurant.ContactEmail,
                ContactNumber = resteurant.ContactNumber,
            };

            return result;
        }
    }
}
