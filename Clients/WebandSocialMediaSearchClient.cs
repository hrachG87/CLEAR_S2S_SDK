using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class WebandSocialMediaSearchClient
{
    private readonly HttpClient _httpClient;

    public WebandSocialMediaSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults28Response> createSearchResults_28Async(createSearchResults28Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/webandsocialmedia/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults28Response>(responseXml);
    }

    public async Task<getSearchResults8Response> getSearchResults_8Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/webandsocialmedia/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSearchResults8Response>(responseXml);
    }

}
