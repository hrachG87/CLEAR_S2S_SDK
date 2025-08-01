using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PhoneSearchClient
{
    private readonly HttpClient _httpClient;

    public PhoneSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PhoneResults> createSearchResults_27Async(PhoneSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/phone/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PhoneResults>(xmlString);
    }

    public async Task<PhoneResultsPage> getGroupRange_16Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/phone/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PhoneResultsPage>(xmlString);
    }

}
