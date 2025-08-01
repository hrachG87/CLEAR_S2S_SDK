using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class LicenseSearchClient
{
    private readonly HttpClient _httpClient;

    public LicenseSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults19Response> createSearchResults_19Async(createSearchResults19Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/license/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults19Response>(responseXml);
    }

    public async Task<getGroupRange10Response> getGroupRange_10Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/license/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange10Response>(responseXml);
    }

}
