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

    public async Task<createSearchResults31Response> createSearchResults_31Async(createSearchResults31Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/watercraft/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults31Response>(responseXml);
    }

    public async Task<getGroupRange19Response> getGroupRange_19Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/watercraft/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange19Response>(responseXml);
    }

}
