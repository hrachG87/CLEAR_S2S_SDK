using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonAssociateAnalyticsSearchClient
{
    private readonly HttpClient _httpClient;

    public PersonAssociateAnalyticsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<startSearch1Response> startSearch_1Async(startSearch1Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/person/assocanalytics/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<startSearch1Response>(responseXml);
    }

    public async Task<getResults1Response> getResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/person/assocanalytics/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getResults1Response>(responseXml);
    }

}
