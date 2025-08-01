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

    public async Task<AdverseMediaMonitorAddSubjectsResult> addMonitorSubjectsAsync(AdverseMediaMonitorAddSubjectsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/addMonitorSubjects", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorAddSubjectsResult>(xmlString);
    }

    public async Task<AdverseMediaMonitorAddSubjectsStatusResult> getAddMonitorSubjectsStatusAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/addMonitorSubjects/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorAddSubjectsStatusResult>(xmlString);
    }

    public async Task<AdverseMediaMonitorAnalyticsResponse> getAnalyticsAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/analytics");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorAnalyticsResponse>(xmlString);
    }

    public async Task<AdverseMediaCreateMonitorResult> createMonitorAsync(AdverseMediaCreateMonitorRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/createMonitor", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaCreateMonitorResult>(xmlString);
    }

    public async Task<AdverseMediaCreateMonitorStatusResult> getCreateMonitorStatusAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/createMonitor/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaCreateMonitorStatusResult>(xmlString);
    }

    public async Task<AdverseMediaDeleteMonitorResult> deleteMonitorAsync(AdverseMediaDeleteMonitorRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/deleteMonitor", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaDeleteMonitorResult>(xmlString);
    }

    public async Task<AdverseMediaMonitorDeleteSubjectsResult> deleteMonitorSubjectsAsync(AdverseMediaMonitorDeleteSubjectsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/deleteMonitorSubjects", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorDeleteSubjectsResult>(xmlString);
    }

    public async Task<AdverseMediaMonitorListDetail> getMonitorListDetailAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorListDetail");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorListDetail>(xmlString);
    }

    public async Task<AdverseMediaMonitorListsResponse> getMonitorListsAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorLists");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorListsResponse>(xmlString);
    }

    public async Task<AdverseMediaMonitorResults> monitorResultsAsync(AdverseMediaMonitorResultsRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/monitorResults", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorResults>(xmlString);
    }

    public async Task<AdverseMediaMonitorResultsPage> getMonitorResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorResults/{{id}}");
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaMonitorResultsPage>(xmlString);
    }

    public async Task<AdverseMediaUpdateMonitorResult> updateMonitorAsync(AdverseMediaUpdateMonitorRequest request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/updateMonitor", content);
        response.EnsureSuccessStatusCode();
        var xmlString = await response.Content.ReadAsStringAsync();
        return XmlHelper.Deserialize<AdverseMediaUpdateMonitorResult>(xmlString);
    }

}
