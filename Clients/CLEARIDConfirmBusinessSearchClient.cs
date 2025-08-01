using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CLEARIDConfirmBusinessSearchClient
{
    private readonly HttpClient _httpClient;

    public CLEARIDConfirmBusinessSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults5Response> createSearchResults_5Async(createSearchResults5Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/eidvbusiness/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults5Response>(responseXml);
    }

    public async Task<getSearchResults2Response> getSearchResults_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/eidvbusiness/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults2Response>(responseXml);
    }

}
