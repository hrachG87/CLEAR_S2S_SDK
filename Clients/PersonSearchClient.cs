using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class PersonSearchClient
{
    private readonly HttpClient _httpClient;

    public PersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PersonResults> createSearchResults_12Async(PersonSearchRequestV3 request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/person/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonResults>(xmlString);
    }

    public async Task<PersonResultsPageV3> getGroupRange_7Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/person/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonResultsPageV3>(xmlString);
    }

    public async Task<PersonResultsPageV3> getGroupRange_6Async(string id, string groupId)
    {
        var response = await _httpClient.GetAsync($"/v3/person/searchResults/{{id}}/{{groupId}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<PersonResultsPageV3>(xmlString);
    }

}
