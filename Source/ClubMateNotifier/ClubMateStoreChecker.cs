using System.Net.Http.Json;

namespace ClubMateNotifier;

public class ClubMateStoreChecker
{
    private const string StoreApi =
        "https://cdn5.editmysite.com/app/store/api/v18/editor/users/139049822/sites/982743195728728276/products";
    
    private HttpClient _httpClient;

    public ClubMateStoreChecker(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Products?> GetAllProducts()
    {
        return await _httpClient.GetFromJsonAsync<Products>(StoreApi);
    }
}