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

    public async Task<createSearchResultsResponse> createSearchResultsAsync(createSearchResultsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResultsResponse>(responseXml);
    }

    public async Task<getSearchResultsResponse> getSearchResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResultsResponse>(responseXml);
    }

}
