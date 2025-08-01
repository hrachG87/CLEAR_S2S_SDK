using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class BusinessReportClient
{
    private readonly HttpClient _httpClient;

    public BusinessReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<BusinessReportResults> createReportResults_1Async(BusinessReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessReportResults>(xmlString);
    }

    public async Task<BusinessReportDetails> getBusinessReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/businessReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessReportDetails>(xmlString);
    }

}
