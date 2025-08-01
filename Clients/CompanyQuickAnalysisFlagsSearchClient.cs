using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CompanyQuickAnalysisFlagsSearchClient
{
    private readonly HttpClient _httpClient;

    public CompanyQuickAnalysisFlagsSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CompanyQuickAnalysisFlagResults> createSearchResults_24Async(CompanyQuickAnalysisFlagRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/quickanalysis/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CompanyQuickAnalysisFlagResults>(xmlString);
    }

    public async Task<CompanyQuickAnalysisFlagResultsPage> getGroupRange_13Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/quickanalysis/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CompanyQuickAnalysisFlagResultsPage>(xmlString);
    }

}
