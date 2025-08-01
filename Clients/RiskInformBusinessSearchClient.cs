using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RiskInformBusinessSearchClient
{
    private readonly HttpClient _httpClient;

    public RiskInformBusinessSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults14Response> createSearchResults_14Async(createSearchResults14Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskinformbusiness/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults14Response>(responseXml);
    }

    public async Task<getSearchResults4Response> getSearchResults_4Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskinformbusiness/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults4Response>(responseXml);
    }

}
