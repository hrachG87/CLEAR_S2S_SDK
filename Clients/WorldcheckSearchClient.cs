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

    public async Task<createSearchResults29Response> createSearchResults_29Async(createSearchResults29Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/worldcheck/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults29Response>(responseXml);
    }

    public async Task<getGroupRange17Response> getGroupRange_17Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/worldcheck/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange17Response>(responseXml);
    }

}
