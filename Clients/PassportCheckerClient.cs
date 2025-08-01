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

    public async Task<PassportCheckerResult> createSearchResults_10Async(PassportCheckerRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/passportchecker/results", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PassportCheckerResult>(xmlString);
    }

}
