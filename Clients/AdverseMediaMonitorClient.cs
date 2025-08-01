using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class AdverseMediaMonitorClient
{
    private readonly HttpClient _httpClient;

    public AdverseMediaMonitorClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<addMonitorSubjectsResponse> addMonitorSubjectsAsync(addMonitorSubjectsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/addMonitorSubjects", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<addMonitorSubjectsResponse>(responseXml);
    }

    public async Task<getAddMonitorSubjectsStatusResponse> getAddMonitorSubjectsStatusAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/addMonitorSubjects/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getAddMonitorSubjectsStatusResponse>(responseXml);
    }

    public async Task<getAnalyticsResponse> getAnalyticsAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/analytics");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getAnalyticsResponse>(responseXml);
    }

    public async Task<createMonitorResponse> createMonitorAsync(createMonitorRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/createMonitor", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<createMonitorResponse>(responseXml);
    }

    public async Task<getCreateMonitorStatusResponse> getCreateMonitorStatusAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/createMonitor/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getCreateMonitorStatusResponse>(responseXml);
    }

    public async Task<deleteMonitorResponse> deleteMonitorAsync(deleteMonitorRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/deleteMonitor", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<deleteMonitorResponse>(responseXml);
    }

    public async Task<deleteMonitorSubjectsResponse> deleteMonitorSubjectsAsync(deleteMonitorSubjectsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/deleteMonitorSubjects", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<deleteMonitorSubjectsResponse>(responseXml);
    }

    public async Task<getMonitorListDetailResponse> getMonitorListDetailAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorListDetail");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getMonitorListDetailResponse>(responseXml);
    }

    public async Task<getMonitorListsResponse> getMonitorListsAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorLists");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getMonitorListsResponse>(responseXml);
    }

    public async Task<monitorResultsResponse> monitorResultsAsync(monitorResultsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/monitorResults", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<monitorResultsResponse>(responseXml);
    }

    public async Task<getMonitorResultsResponse> getMonitorResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<getMonitorResultsResponse>(responseXml);
    }

    public async Task<updateMonitorResponse> updateMonitorAsync(updateMonitorRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/updateMonitor", content);
        response.EnsureSuccessStatusCode();
        var responseXml = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<updateMonitorResponse>(responseXml);
    }

}
