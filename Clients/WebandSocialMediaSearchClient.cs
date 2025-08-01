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

    public async Task<WebAndSocialMediaSearchResults> createSearchResults_28Async(WebAndSocialMediaSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/webandsocialmedia/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WebAndSocialMediaSearchResults>(xmlString);
    }

    public async Task<WebAndSocialMediaSearchResultsPage> getSearchResults_8Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/webandsocialmedia/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WebAndSocialMediaSearchResultsPage>(xmlString);
    }

}
