using AssignmentsWeb.Models.API.BreakingBad;
using AssignmentsWeb.Models.API.Pokemon;

namespace AssignmentsWeb.Services.Interfaces
{
    public interface IHTTPService
    {
        Task<List<BreakingBad>?> GetAmountOfBreakingBadQuotes(string id);
        Task<List<BreakingBad>?> GetRandomBreakingBadQuote();
        Task<Pokemon?> GetPokemons();
    }
}