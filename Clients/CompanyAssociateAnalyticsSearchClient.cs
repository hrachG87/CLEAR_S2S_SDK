using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CompanyAssociateAnalyticsSearchClient
{
    private readonly HttpClient _httpClient;

    public CompanyAssociateAnalyticsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<startSearchResponse> startSearchAsync(startSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/assocanalytics/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<startSearchResponse>(responseXml);
    }

    public async Task<getResultsResponse> getResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/assocanalytics/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getResultsResponse>(responseXml);
    }

}
