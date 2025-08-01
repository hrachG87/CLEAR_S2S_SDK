using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PassportCheckerClient
{
    private readonly HttpClient _httpClient;

    public PassportCheckerClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults10Response> createSearchResults_10Async(createSearchResults10Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/passportchecker/results", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults10Response>(responseXml);
    }

}
