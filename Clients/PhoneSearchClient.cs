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

    public async Task<createSearchResults27Response> createSearchResults_27Async(createSearchResults27Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/phone/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults27Response>(responseXml);
    }

    public async Task<getGroupRange16Response> getGroupRange_16Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/phone/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange16Response>(responseXml);
    }

}
