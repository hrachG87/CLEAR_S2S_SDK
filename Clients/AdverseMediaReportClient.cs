using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class AdverseMediaReportClient
{
    private readonly HttpClient _httpClient;

    public AdverseMediaReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createReportResultsResponse> createReportResultsAsync(createReportResultsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemediaReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResultsResponse>(responseXml);
    }

    public async Task<getReportResultsResponse> getReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemediaReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getReportResultsResponse>(responseXml);
    }

}
