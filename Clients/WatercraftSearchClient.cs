using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class WatercraftSearchClient
{
    private readonly HttpClient _httpClient;

    public WatercraftSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WatercraftResults> createSearchResults_31Async(WatercraftSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/watercraft/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WatercraftResults>(xmlString);
    }

    public async Task<WatercraftResultsPage> getGroupRange_19Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/watercraft/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WatercraftResultsPage>(xmlString);
    }

}
