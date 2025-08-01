using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class NewsSearchClient
{
    private readonly HttpClient _httpClient;

    public NewsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults20Response> createSearchResults_20Async(createSearchResults20Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/news/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults20Response>(responseXml);
    }

    public async Task<getGroupRange11Response> getGroupRange_11Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/news/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange11Response>(responseXml);
    }

    public async Task<getRecordResponse> getRecordAsync(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v2/news/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getRecordResponse>(responseXml);
    }

}
