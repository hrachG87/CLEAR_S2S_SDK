using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonReportClient
{
    private readonly HttpClient _httpClient;

    public PersonReportClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createReportResults5Response> createReportResults_5Async(createReportResults5Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/personReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createReportResults5Response>(responseXml);
    }

    public async Task<getPersonReportResultsResponse> getPersonReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/personReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getPersonReportResultsResponse>(responseXml);
    }

}
