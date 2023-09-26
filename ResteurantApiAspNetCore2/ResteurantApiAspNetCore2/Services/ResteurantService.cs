using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using ResteurantApiAspNetCore2.DTOs;
using ResteurantApiAspNetCore2.Mappers;
using ResteurantApiAspNetCore2.Repositories.Interfaces;
using ResteurantApiAspNetCore2.Services.Interfaces;

namespace ResteurantApiAspNetCore2.Services
{
    public class ResteurantService : IResteurantService
    {
        private readonly IResteurantRepository _repository; // - wstrzykiwanie IResteurantRepository

        public ResteurantService(IResteurantRepository repository)
        {
            _repository = repository;
        }

        //public List<ResteurantDto> GetAll() - robimy synchroniczne
        public async Task<ErrorOr<List<ResteurantDto>>> GetAll()
        {
            var resteurants = await _repository.GetAll();
            var result = new List<ResteurantDto>();

            foreach (var resteurant in resteurants)
            {
                result.Add(ResteurantMapper.MapFrom(resteurant));
            }

            return result;
        }
    }
}
