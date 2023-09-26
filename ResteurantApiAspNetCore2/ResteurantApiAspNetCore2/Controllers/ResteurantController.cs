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
    //[ApiController]
    //[Route("api/[controller]")]

    public class ResteurantController : ApiController
    {
        //private readonly IResteurantRepository _repository; // - przeniesienie do ResteurantServices
        private readonly IResteurantService _service;

        //ctor - tworzenie konstrukrora

        //public ResteurantController(IResteurantRepository repository, IResteurantService service)
        public ResteurantController(IResteurantService service)
        {
            //_repository = new ResteurantRepository();
            //_repository = repository;
            _service = service;
        }

        //[HttpGet(Name = "GetAllResteurant")]
        [HttpGet]

        //public List<ResteurantDto> GetAll()
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

            //var result = await _service.GetAll();

            //return Ok(result);
        }
    }
}