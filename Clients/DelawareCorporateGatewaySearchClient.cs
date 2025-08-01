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

    public async Task<DECorpResults> createSearchResults_2Async(DECorpSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/decorp/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<DECorpResults>(xmlString);
    }

    public async Task<DECorpResultsPage> getGroupRange_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/decorp/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<DECorpResultsPage>(xmlString);
    }

}
