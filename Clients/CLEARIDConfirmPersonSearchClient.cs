using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CLEARIDConfirmPersonSearchClient
{
    private readonly HttpClient _httpClient;

    public CLEARIDConfirmPersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<EIDVPersonResults> createSearchResults_6Async(EIDVPersonSearch request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/eidvperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<EIDVPersonResults>(xmlString);
    }

    public async Task<EIDVPersonSearchResponse> getSearchResults_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/eidvperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<EIDVPersonSearchResponse>(xmlString);
    }

}
