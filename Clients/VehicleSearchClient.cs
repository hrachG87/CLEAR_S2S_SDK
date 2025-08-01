using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class VehicleSearchClient
{
    private readonly HttpClient _httpClient;

    public VehicleSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults30Response> createSearchResults_30Async(createSearchResults30Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/vehicle/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults30Response>(responseXml);
    }

    public async Task<getGroupRange18Response> getGroupRange_18Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/vehicle/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange18Response>(responseXml);
    }

}
