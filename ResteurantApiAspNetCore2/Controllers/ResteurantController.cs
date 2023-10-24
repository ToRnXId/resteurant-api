using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using ResteurantApiAspNetCore2.Controllers.Common;
using ResteurantApiAspNetCore2.DTOs;
using ResteurantApiAspNetCore2.Mappers;
using ResteurantApiAspNetCore2.Repositories;
using ResteurantApiAspNetCore2.Repositories.Interfaces;
using ResteurantApiAspNetCore2.Services.Interfaces;


namespace ResteurantApiAspNetCore2.Controllers
{
    public class ResteurantController : ApiController
    {
        private readonly IResteurantService _service;

        //ctor - tworzenie konstrukrora

        public ResteurantController(IResteurantService service)
        {
            _service = service;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            //await Task.CompletedTask; - trik z taskami

            //var resteurants = _repository.GetAll();
            //var result = new List<ResteurantDto>();

            //foreach (var resteurant in resteurants)
            //{
            //    result.Add(ResteurantMapper.MapFrom(resteurant));
            //}

            //return result;

            ErrorOr<List<ResteurantDto>> result = await _service.GetAll();

            return result.Match(
                res => Ok(res),
                errors => Problem(errors));
        }
    }
}