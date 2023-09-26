using ResteurantApiAspNetCore2.DTOs;
using ResteurantApiAspNetCore2.Entities;

namespace ResteurantApiAspNetCore2.Repositories.Interfaces
{
    public interface IResteurantRepository
    {
        Task<List<Resteurant>> GetAll();
    }
}
