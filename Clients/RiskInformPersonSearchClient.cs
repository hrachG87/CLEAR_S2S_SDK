using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RiskInformPersonSearchClient
{
    private readonly HttpClient _httpClient;

    public RiskInformPersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RiskInformPersonSearchResults> createSearchResults_16Async(RiskInformPersonSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/riskinformperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonSearchResults>(xmlString);
    }

    public async Task<RiskInformPersonSearchResponseV3> getSearchResults_6Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/riskinformperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonSearchResponseV3>(xmlString);
    }

    public async Task<RiskInformPersonSearchResults> createSearchResults_15Async(RiskInformPersonSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskinformperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonSearchResults>(xmlString);
    }

    public async Task<RiskInformPersonSearchResponse> getSearchResults_5Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskinformperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonSearchResponse>(xmlString);
    }

}
