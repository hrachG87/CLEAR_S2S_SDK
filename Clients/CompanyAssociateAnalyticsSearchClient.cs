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

    public async Task<CompanyAssociateAnalyticsResults> startSearchAsync(CompanyAssociateAnalyticsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/assocanalytics/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CompanyAssociateAnalyticsResults>(xmlString);
    }

    public async Task<CompanyAssociateAnalyticsResultsPage> getResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/assocanalytics/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CompanyAssociateAnalyticsResultsPage>(xmlString);
    }

}
