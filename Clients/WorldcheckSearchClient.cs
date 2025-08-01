using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class WorldcheckSearchClient
{
    private readonly HttpClient _httpClient;

    public WorldcheckSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WorldcheckDocumentResults> createSearchResults_29Async(WorldcheckDocumentSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/worldcheck/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WorldcheckDocumentResults>(xmlString);
    }

    public async Task<WorldcheckDocumentResultsPage> getGroupRange_17Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/worldcheck/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WorldcheckDocumentResultsPage>(xmlString);
    }

}
