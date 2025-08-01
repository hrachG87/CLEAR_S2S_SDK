using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ExperianBusinessCreditSearchClient
{
    private readonly HttpClient _httpClient;

    public ExperianBusinessCreditSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults3Response> createSearchResults_3Async(createSearchResults3Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/expbuscredit/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults3Response>(responseXml);
    }

    public async Task<getGroupRange2Response> getGroupRange_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/expbuscredit/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange2Response>(responseXml);
    }

}
