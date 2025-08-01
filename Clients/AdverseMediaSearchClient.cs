using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class AdverseMediaSearchClient
{
    private readonly HttpClient _httpClient;

    public AdverseMediaSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AdverseMediaSearchResults> createSearchResultsAsync(AdverseMediaSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaSearchResults>(xmlString);
    }

    public async Task<AdverseMediaResultsPage> getSearchResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaResultsPage>(xmlString);
    }

}
