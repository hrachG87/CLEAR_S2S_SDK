using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CourtSearchClient
{
    private readonly HttpClient _httpClient;

    public CourtSearchClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<createSearchResults22Response> createSearchResults_22Async(createSearchResults22Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/court/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults22Response>(responseXml);
    }

    public async Task<getSummarizedGroupsByRange1Response> getSummarizedGroupsByRange_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/court/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSummarizedGroupsByRange1Response>(responseXml);
    }

    public async Task<getDocketDetails1Response> getDocketDetails_1Async(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v3/court/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getDocketDetails1Response>(responseXml);
    }

    public async Task<createSearchResults21Response> createSearchResults_21Async(createSearchResults21Request request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/court/searchResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createSearchResults21Response>(responseXml);
    }

    public async Task<getSummarizedGroupsByRangeResponse> getSummarizedGroupsByRangeAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/court/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getSummarizedGroupsByRangeResponse>(responseXml);
    }

    public async Task<getDocketDetailsResponse> getDocketDetailsAsync(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v2/court/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getDocketDetailsResponse>(responseXml);
    }

}
