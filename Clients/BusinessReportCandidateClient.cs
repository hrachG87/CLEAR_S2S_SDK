using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class BusinessReportCandidateClient
{
    private readonly HttpClient _httpClient;

    public BusinessReportCandidateClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<BusinessReportCandidateResults> createReportResults_9Async(BusinessReportCandidateRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessReportCandidate/reportResultsCandidate", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessReportCandidateResults>(xmlString);
    }

}
