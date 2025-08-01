using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CLEARIDConfirmInternationalPersonSearchClient
{
    private readonly HttpClient _httpClient;

    public CLEARIDConfirmInternationalPersonSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CIDCInternationalPersonResults> createSearchResults_4Async(CIDCInternationalPersonSearch request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/cidcinternationalperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CIDCInternationalPersonResults>(xmlString);
    }

    public async Task<CIDCInternationalPersonSearchResponse> getSearchResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/cidcinternationalperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<CIDCInternationalPersonSearchResponse>(xmlString);
    }

}
