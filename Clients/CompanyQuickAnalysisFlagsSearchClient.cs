using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CompanyQuickAnalysisFlagsSearchClient
{
    private readonly HttpClient _httpClient;

    public CompanyQuickAnalysisFlagsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults24Response> createSearchResults_24Async(createSearchResults24Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/quickanalysis/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults24Response>(responseXml);
    }

    public async Task<getGroupRange13Response> getGroupRange_13Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/quickanalysis/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange13Response>(responseXml);
    }

}
