using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class BusinessDocumentSearchClient
{
    private readonly HttpClient _httpClient;

    public BusinessDocumentSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<BusinessDocumentResults> createSearchResults_18Async(BusinessDocumentSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessdocument/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessDocumentResults>(xmlString);
    }

    public async Task<BusinessDocumentResultsPage> getGroupRange_9Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/businessdocument/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<BusinessDocumentResultsPage>(xmlString);
    }

}
