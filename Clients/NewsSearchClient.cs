using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class NewsSearchClient
{
    private readonly HttpClient _httpClient;

    public NewsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<NewsSearchResults> createSearchResults_20Async(NewsSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/news/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<NewsSearchResults>(xmlString);
    }

    public async Task<NewsSummaryPage> getGroupRange_11Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/news/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<NewsSummaryPage>(xmlString);
    }

    public async Task<NewsResultsPage> getRecordAsync(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v2/news/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<NewsResultsPage>(xmlString);
    }

}
