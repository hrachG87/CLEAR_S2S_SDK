using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RiskInformBusinessSearchClient
{
    private readonly HttpClient _httpClient;

    public RiskInformBusinessSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RiskInformBusinessSearchResults> createSearchResults_14Async(RiskInformBusinessSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskinformbusiness/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformBusinessSearchResults>(xmlString);
    }

    public async Task<RiskInformBusinessSearchResponse> getSearchResults_4Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskinformbusiness/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformBusinessSearchResponse>(xmlString);
    }

}
