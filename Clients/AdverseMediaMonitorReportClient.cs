using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class AdverseMediaMonitorReportClient
{
    private readonly HttpClient _httpClient;

    public AdverseMediaMonitorReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AdverseMediaMonitorReportResults> createMonitorReportResultsAsync(AdverseMediaMonitorReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemediaReport/monitorReportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorReportResults>(xmlString);
    }

    public async Task<AdverseMediaMonitorReportDetails> getMonitorReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemediaReport/monitorReportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorReportDetails>(xmlString);
    }

}
