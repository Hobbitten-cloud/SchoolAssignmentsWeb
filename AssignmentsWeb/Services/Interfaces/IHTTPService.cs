using AssignmentsWeb.Models.API;

namespace AssignmentsWeb.Services.Interfaces
{
    public interface IHTTPService
    {
        Task<Root?> GetCatById(int id);
        Task<Root?> GetRandomCat();
    }
}