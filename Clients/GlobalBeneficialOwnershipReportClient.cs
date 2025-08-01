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

    public async Task<GlobalBeneficialOwnershipReportResults> createReportResults_4Async(GlobalBeneficialOwnershipReportRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/globalbeneficialownershipReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<GlobalBeneficialOwnershipReportResults>(xmlString);
    }

    public async Task<GlobalBeneficialOwnershipReportDetails> getReportResults_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownershipReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<GlobalBeneficialOwnershipReportDetails>(xmlString);
    }

}
