using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class LicenseSearchClient
{
    private readonly HttpClient _httpClient;

    public LicenseSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<LicenseResults> createSearchResults_19Async(LicenseSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/license/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<LicenseResults>(xmlString);
    }

    public async Task<LicenseResultsPage> getGroupRange_10Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/license/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<LicenseResultsPage>(xmlString);
    }

}
