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

    public async Task<AdverseMediaReportResults> createReportResultsAsync(AdverseMediaReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemediaReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaReportResults>(xmlString);
    }

    public async Task<AdverseMediaReportDetails> getReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemediaReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaReportDetails>(xmlString);
    }

}
