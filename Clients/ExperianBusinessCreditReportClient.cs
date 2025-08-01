using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ExperianBusinessCreditReportClient
{
    private readonly HttpClient _httpClient;

    public ExperianBusinessCreditReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createReportResults3Response> createReportResults_3Async(createReportResults3Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/expbuscreditReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults3Response>(responseXml);
    }

    public async Task<getReportResults1Response> getReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/expbuscreditReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getReportResults1Response>(responseXml);
    }

}
