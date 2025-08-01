using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class DelawareCorporateGatewayReportClient
{
    private readonly HttpClient _httpClient;

    public DelawareCorporateGatewayReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createReportResults2Response> createReportResults_2Async(createReportResults2Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/decorpReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults2Response>(responseXml);
    }

    public async Task<getBusinessReportResults1Response> getBusinessReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/decorpReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getBusinessReportResults1Response>(responseXml);
    }

}
