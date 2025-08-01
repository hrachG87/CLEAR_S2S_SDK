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

    public async Task<DECorpReportResults> createReportResults_2Async(DECorpReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/decorpReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<DECorpReportResults>(xmlString);
    }

    public async Task<DECorpReportDetails> getBusinessReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/decorpReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<DECorpReportDetails>(xmlString);
    }

}
