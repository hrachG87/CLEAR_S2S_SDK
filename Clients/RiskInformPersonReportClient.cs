using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RiskInformPersonReportClient
{
    private readonly HttpClient _httpClient;

    public RiskInformPersonReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RiskInformPersonReportResults> createReportResults_7Async(RiskInformPersonReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/riskInformPersonReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonReportResults>(xmlString);
    }

    public async Task<RiskInformPersonReportDetailsV3> getRiskInformPersonReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/riskInformPersonReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonReportDetailsV3>(xmlString);
    }

    public async Task<RiskInformPersonReportResults> createReportResults_6Async(RiskInformPersonReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskInformPersonReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonReportResults>(xmlString);
    }

    public async Task<RiskInformPersonReportDetails> getRiskInformPersonReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskInformPersonReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformPersonReportDetails>(xmlString);
    }

}
