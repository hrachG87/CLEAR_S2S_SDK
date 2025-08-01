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

    public async Task<PersonReportCandidateResults> createReportResults_10Async(PersonReportCandidateRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/personReportCandidate/reportResultsCandidate", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonReportCandidateResults>(xmlString);
    }

}
