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

    public async Task<createReportResults9Response> createReportResults_9Async(createReportResults9Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessReportCandidate/reportResultsCandidate", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults9Response>(responseXml);
    }

}
