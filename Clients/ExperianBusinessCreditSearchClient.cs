using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ExperianBusinessCreditSearchClient
{
    private readonly HttpClient _httpClient;

    public ExperianBusinessCreditSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ExpBusCreditResults> createSearchResults_3Async(ExpBusCreditSearchRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/expbuscredit/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<ExpBusCreditResults>(xmlString);
    }

    public async Task<ExpBusCreditResultsPage> getGroupRange_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/expbuscredit/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<ExpBusCreditResultsPage>(xmlString);
    }

}
