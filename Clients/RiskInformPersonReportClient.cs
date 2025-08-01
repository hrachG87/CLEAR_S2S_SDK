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

    public async Task<createReportResults7Response> createReportResults_7Async(createReportResults7Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/riskInformPersonReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults7Response>(responseXml);
    }

    public async Task<getRiskInformPersonReportResults1Response> getRiskInformPersonReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/riskInformPersonReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getRiskInformPersonReportResults1Response>(responseXml);
    }

    public async Task<createReportResults6Response> createReportResults_6Async(createReportResults6Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskInformPersonReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults6Response>(responseXml);
    }

    public async Task<getRiskInformPersonReportResultsResponse> getRiskInformPersonReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskInformPersonReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getRiskInformPersonReportResultsResponse>(responseXml);
    }

}
