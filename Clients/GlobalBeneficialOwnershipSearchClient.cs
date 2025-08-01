using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class GlobalBeneficialOwnershipSearchClient
{
    private readonly HttpClient _httpClient;

    public GlobalBeneficialOwnershipSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<getGroupResponse> getGroupAsync(string groupId)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownership/entityDetails/{{groupId}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupResponse>(responseXml);
    }

    public async Task<createSearchResults7Response> createSearchResults_7Async(createSearchResults7Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/globalbeneficialownership/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults7Response>(responseXml);
    }

    public async Task<getGroupRange3Response> getGroupRange_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownership/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getGroupRange3Response>(responseXml);
    }

}
