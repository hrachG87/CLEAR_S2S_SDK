using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RiskInformPersonSearchClient
{
    private readonly HttpClient _httpClient;

    public RiskInformPersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults16Response> createSearchResults_16Async(createSearchResults16Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/riskinformperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults16Response>(responseXml);
    }

    public async Task<getSearchResults6Response> getSearchResults_6Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/riskinformperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults6Response>(responseXml);
    }

    public async Task<createSearchResults15Response> createSearchResults_15Async(createSearchResults15Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskinformperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults15Response>(responseXml);
    }

    public async Task<getSearchResults5Response> getSearchResults_5Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskinformperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults5Response>(responseXml);
    }

}
