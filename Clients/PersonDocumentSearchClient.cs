using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonDocumentSearchClient
{
    private readonly HttpClient _httpClient;

    public PersonDocumentSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults26Response> createSearchResults_26Async(createSearchResults26Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/persondocument/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults26Response>(responseXml);
    }

    public async Task<getGroupRange15Response> getGroupRange_15Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/persondocument/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange15Response>(responseXml);
    }

}
