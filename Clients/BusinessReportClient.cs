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

    public async Task<createReportResults1Response> createReportResults_1Async(createReportResults1Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults1Response>(responseXml);
    }

    public async Task<getBusinessReportResultsResponse> getBusinessReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/businessReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getBusinessReportResultsResponse>(responseXml);
    }

}
