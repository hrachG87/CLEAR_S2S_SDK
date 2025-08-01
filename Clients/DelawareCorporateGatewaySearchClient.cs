using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class DelawareCorporateGatewaySearchClient
{
    private readonly HttpClient _httpClient;

    public DelawareCorporateGatewaySearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults2Response> createSearchResults_2Async(createSearchResults2Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/decorp/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults2Response>(responseXml);
    }

    public async Task<getGroupRange1Response> getGroupRange_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/decorp/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange1Response>(responseXml);
    }

}
