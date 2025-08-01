using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RealPropertySearchClient
{
    private readonly HttpClient _httpClient;

    public RealPropertySearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults13Response> createSearchResults_13Async(createSearchResults13Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/realproperty/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults13Response>(responseXml);
    }

    public async Task<getGroupRange8Response> getGroupRange_8Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/realproperty/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange8Response>(responseXml);
    }

}
