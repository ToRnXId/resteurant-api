using ErrorOr;
using ResteurantApiAspNetCore2.DTOs;

namespace ResteurantApiAspNetCore2.Services.Interfaces
{
    public interface IResteurantService
    {
        Task<ErrorOr<List<ResteurantDto>>> GetAll();
    }
}
