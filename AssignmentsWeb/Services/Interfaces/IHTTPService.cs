using AssignmentsWeb.Models.API;

namespace AssignmentsWeb.Services.Interfaces
{
    public interface IHTTPService
    {
        Task<List<Root>?> GetRandomBreakingBadQuote();
        Task<List<Root>?> GetAmountOfBreakingBadQuotes(string id);
    }
}