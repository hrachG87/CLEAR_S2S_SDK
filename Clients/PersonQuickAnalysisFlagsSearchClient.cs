using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonQuickAnalysisFlagsSearchClient
{
    private readonly HttpClient _httpClient;

    public PersonQuickAnalysisFlagsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults25Response> createSearchResults_25Async(createSearchResults25Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/person/quickanalysis/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults25Response>(responseXml);
    }

    public async Task<getGroupRange14Response> getGroupRange_14Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/person/quickanalysis/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange14Response>(responseXml);
    }

}
