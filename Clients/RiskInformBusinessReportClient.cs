using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class RiskInformBusinessReportClient
{
    private readonly HttpClient _httpClient;

    public RiskInformBusinessReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<RiskInformBusinessReportResults> createReportResults_8Async(RiskInformBusinessReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskInformBusinessReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformBusinessReportResults>(xmlString);
    }

    public async Task<RiskInformBusinessReportDetails> getReportResults_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskInformBusinessReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<RiskInformBusinessReportDetails>(xmlString);
    }

}
