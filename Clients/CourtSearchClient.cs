using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CourtSearchClient
{
    private readonly HttpClient _httpClient;

    public CourtSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CourtResults> createSearchResults_22Async(CourtSearchRequestV3 request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/court/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CourtResults>(xmlString);
    }

    public async Task<CourtResultsPage> getSummarizedGroupsByRange_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/court/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CourtResultsPage>(xmlString);
    }

    public async Task<CourtDocumentDetailsPage> getDocketDetails_1Async(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v3/court/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CourtDocumentDetailsPage>(xmlString);
    }

    public async Task<CourtResults> createSearchResults_21Async(CourtSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/court/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CourtResults>(xmlString);
    }

    public async Task<CourtResultsPage> getSummarizedGroupsByRangeAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/court/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CourtResultsPage>(xmlString);
    }

    public async Task<CourtDocumentDetailsPage> getDocketDetailsAsync(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v2/court/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CourtDocumentDetailsPage>(xmlString);
    }

}
