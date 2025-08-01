using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonQuickAnalysisFlagsSearchClient
{
    private readonly HttpClient _httpClient;

    public PersonQuickAnalysisFlagsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PersonQuickAnalysisFlagResults> createSearchResults_25Async(PersonQuickAnalysisFlagRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/person/quickanalysis/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonQuickAnalysisFlagResults>(xmlString);
    }

    public async Task<PersonQuickAnalysisFlagResultsPage> getGroupRange_14Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/person/quickanalysis/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonQuickAnalysisFlagResultsPage>(xmlString);
    }

}
