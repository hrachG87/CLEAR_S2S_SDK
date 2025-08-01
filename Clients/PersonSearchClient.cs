using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonSearchClient
{
    private readonly HttpClient _httpClient;

    public PersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults12Response> createSearchResults_12Async(createSearchResults12Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/person/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults12Response>(responseXml);
    }

    public async Task<getGroupRange7Response> getGroupRange_7Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/person/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange7Response>(responseXml);
    }

    public async Task<getGroupRange6Response> getGroupRange_6Async(string id, string groupId)
    {
        var response = await _httpClient.GetAsync($"/v3/person/searchResults/{{id}}/{{groupId}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange6Response>(responseXml);
    }

}
