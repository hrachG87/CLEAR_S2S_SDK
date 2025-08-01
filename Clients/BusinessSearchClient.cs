using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class BusinessSearchClient
{
    private readonly HttpClient _httpClient;

    public BusinessSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<BusinessResults> createSearchResults_1Async(BusinessSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessResults>(xmlString);
    }

    public async Task<BusinessResultsPage> getGroupRangeAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessResultsPage>(xmlString);
    }

}
