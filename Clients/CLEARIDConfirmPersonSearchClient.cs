using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CLEARIDConfirmPersonSearchClient
{
    private readonly HttpClient _httpClient;

    public CLEARIDConfirmPersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults6Response> createSearchResults_6Async(createSearchResults6Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/eidvperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults6Response>(responseXml);
    }

    public async Task<getSearchResults3Response> getSearchResults_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/eidvperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults3Response>(responseXml);
    }

}
