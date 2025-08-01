using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CustomWorkflowSearchClient
{
    private readonly HttpClient _httpClient;

    public CustomWorkflowSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WorkflowResults> createSearchResults_17Async(WorkflowSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/workflow/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WorkflowResults>(xmlString);
    }

    public async Task<WorkflowSearchResponse> getSearchResults_7Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/workflow/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<WorkflowSearchResponse>(xmlString);
    }

}
