using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonReportCandidateClient
{
    private readonly HttpClient _httpClient;

    public PersonReportCandidateClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createReportResults10Response> createReportResults_10Async(createReportResults10Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/personReportCandidate/reportResultsCandidate", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults10Response>(responseXml);
    }

}
