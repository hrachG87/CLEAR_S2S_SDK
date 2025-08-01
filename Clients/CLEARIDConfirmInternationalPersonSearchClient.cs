using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CLEARIDConfirmInternationalPersonSearchClient
{
    private readonly HttpClient _httpClient;

    public CLEARIDConfirmInternationalPersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults4Response> createSearchResults_4Async(createSearchResults4Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/cidcinternationalperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults4Response>(responseXml);
    }

    public async Task<getSearchResults1Response> getSearchResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/cidcinternationalperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults1Response>(responseXml);
    }

}
