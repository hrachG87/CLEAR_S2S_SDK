using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RealPropertySearchClient
{
    private readonly HttpClient _httpClient;

    public RealPropertySearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RealPropertyResults> createSearchResults_13Async(RealPropertySearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/realproperty/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RealPropertyResults>(xmlString);
    }

    public async Task<RealPropertyResultsPage> getGroupRange_8Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/realproperty/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RealPropertyResultsPage>(xmlString);
    }

}
