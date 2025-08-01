using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class GlobalBeneficialOwnershipReportClient
{
    private readonly HttpClient _httpClient;

    public GlobalBeneficialOwnershipReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createReportResults4Response> createReportResults_4Async(createReportResults4Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/globalbeneficialownershipReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults4Response>(responseXml);
    }

    public async Task<getReportResults2Response> getReportResults_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownershipReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getReportResults2Response>(responseXml);
    }

}
