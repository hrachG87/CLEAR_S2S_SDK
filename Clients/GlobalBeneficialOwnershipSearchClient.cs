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

    public async Task<GlobalBeneficialOwnershipEntityDetailsPage> getGroupAsync(string groupId)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownership/entityDetails/{{groupId}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<GlobalBeneficialOwnershipEntityDetailsPage>(xmlString);
    }

    public async Task<GlobalBeneficialOwnershipResults> createSearchResults_7Async(GlobalBeneficialOwnershipSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/globalbeneficialownership/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<GlobalBeneficialOwnershipResults>(xmlString);
    }

    public async Task<GlobalBeneficialOwnershipResultsPage> getGroupRange_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownership/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<GlobalBeneficialOwnershipResultsPage>(xmlString);
    }

}
