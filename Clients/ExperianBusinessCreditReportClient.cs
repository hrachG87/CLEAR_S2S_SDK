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

    public async Task<ExpBusCreditReportResults> createReportResults_3Async(ExpBusCreditReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/expbuscreditReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<ExpBusCreditReportResults>(xmlString);
    }

    public async Task<ExpBusCreditReportDetails> getReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/expbuscreditReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<ExpBusCreditReportDetails>(xmlString);
    }

}
