using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CLEARIDConfirmBusinessSearchClient
{
    private readonly HttpClient _httpClient;

    public CLEARIDConfirmBusinessSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<EIDVBusinessResults> createSearchResults_5Async(EIDVBusinessSearch request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/eidvbusiness/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<EIDVBusinessResults>(xmlString);
    }

    public async Task<EIDVBusinessSearchResponse> getSearchResults_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/eidvbusiness/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<EIDVBusinessSearchResponse>(xmlString);
    }

}
