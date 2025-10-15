using AssignmentsWeb.Models.API;
using AssignmentsWeb.Models.API.BreakingBad;
using AssignmentsWeb.Models.API.Cat;
using AssignmentsWeb.Models.API.Pokemon;

namespace AssignmentsWeb.Services.Interfaces
{
    public interface IHTTPService
    {
        Task<List<BreakingBad>?> GetAmountOfBreakingBadQuotes(string id);
        Task<List<BreakingBad>?> GetRandomBreakingBadQuote();
        Task<Pokemon?> GetPokemons();
        Task<Pokemon?> GetPokemonsByUrl(string url);
        Task<Cat?> GetCat();
    }
}