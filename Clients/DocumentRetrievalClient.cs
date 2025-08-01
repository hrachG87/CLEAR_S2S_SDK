using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class DocumentRetrievalClient
{
    private readonly HttpClient _httpClient;

    public DocumentRetrievalClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<DocumentResults> createSearchResults_23Async(DocumentRetrievalRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/document/retrieval", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<DocumentResults>(xmlString);
    }

    public async Task<DocumentResultsPage> getGroupRange_12Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/document/retrieval/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<DocumentResultsPage>(xmlString);
    }

}
