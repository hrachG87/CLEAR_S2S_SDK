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

    public async Task<PersonAssociateAnalyticsResults> startSearch_1Async(PersonAssociateAnalyticsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/person/assocanalytics/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonAssociateAnalyticsResults>(xmlString);
    }

    public async Task<PersonAssociateAnalyticsResultsPage> getResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/person/assocanalytics/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonAssociateAnalyticsResultsPage>(xmlString);
    }

}
