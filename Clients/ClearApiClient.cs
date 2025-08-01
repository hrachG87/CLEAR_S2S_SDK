using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class ClearApiClient
{
    private readonly HttpClient _httpClient;

    public ClearApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> createSearchResults_15Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskinformperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_1Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_7Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/person/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createMonitorAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/createMonitor", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> addMonitorSubjectsAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/addMonitorSubjects", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getMonitorResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_3Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/expbuscreditReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResultsAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemediaReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_1Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/eidvperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/assocanalytics/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_5Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/eidvbusiness/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_13Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/quickanalysis/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> startSearch_1Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/person/assocanalytics/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/eidvbusiness/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_6Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskInformPersonReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_4Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/globalbeneficialownershipReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getDocketDetails_1Async(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v3/court/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> deleteMonitorAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/deleteMonitor", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getRiskInformPersonReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/riskInformPersonReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_24Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/quickanalysis/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_10Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/license/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getMonitorListDetailAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorListDetail");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_15Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/persondocument/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_8Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskInformBusinessReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_5Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskinformperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getBusinessReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/decorpReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/cidcinternationalperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_30Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/vehicle/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getBusinessReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/businessReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getAddMonitorSubjectsStatusAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/addMonitorSubjects/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_14Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/riskinformbusiness/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSummarizedGroupsByRangeAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/court/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_28Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/webandsocialmedia/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_11Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/news/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_5Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/personReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getPersonReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/personReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_19Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/watercraft/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_2Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/decorp/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_16Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/riskinformperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getCreateMonitorStatusAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/createMonitor/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> deleteMonitorSubjectsAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/deleteMonitorSubjects", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> monitorResultsAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/monitorResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_6Async(string id, string groupId)
    {
        var response = await _httpClient.GetAsync($"/v3/person/searchResults/{{id}}/{{groupId}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_8Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/realproperty/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownership/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_7Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/workflow/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_18Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/vehicle/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_12Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/document/retrieval/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_27Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/phone/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_21Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/court/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_25Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/person/quickanalysis/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getReportResults_3Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskInformBusinessReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_6Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/riskinformperson/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> updateMonitorAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/updateMonitor", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> startSearchAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/business/assocanalytics/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_17Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/workflow/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_20Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/news/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_13Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/realproperty/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_26Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/persondocument/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_17Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/worldcheck/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_12Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/person/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_9Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/businessdocument/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_6Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/eidvperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_9Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessReportCandidate/reportResultsCandidate", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_7Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/globalbeneficialownership/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_19Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/license/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getReportResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/expbuscreditReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/decorp/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_4Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/cidcinternationalperson/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getRecordAsync(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v2/news/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_23Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/document/retrieval", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_3Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/expbuscredit/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_16Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/phone/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_14Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/person/quickanalysis/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getResults_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/person/assocanalytics/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_8Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/webandsocialmedia/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRange_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/expbuscredit/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getMonitorReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemediaReport/monitorReportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getMonitorListsAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/monitorLists");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupAsync(string groupId)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownership/entityDetails/{{groupId}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createMonitorReportResultsAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemediaReport/monitorReportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getReportResults_2Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/globalbeneficialownershipReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResultsAsync(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/adversemedia/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/adversemediaReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getDocketDetailsAsync(string groupId, string recordId)
    {
        var response = await _httpClient.GetAsync($"/v2/court/searchResults/{{groupId}}/{{recordId}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_10Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/passportchecker/results", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_10Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/personReportCandidate/reportResultsCandidate", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSearchResults_4Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskinformbusiness/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_2Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/decorpReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getRiskInformPersonReportResultsAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/riskInformPersonReport/reportResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getGroupRangeAsync(string id)
    {
        var response = await _httpClient.GetAsync($"/v2/business/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_29Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/worldcheck/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createReportResults_7Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/riskInformPersonReport/reportResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_31Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/watercraft/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getSummarizedGroupsByRange_1Async(string id)
    {
        var response = await _httpClient.GetAsync($"/v3/court/searchResults/{{id}}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> getAnalyticsAsync()
    {
        var response = await _httpClient.GetAsync($"/v2/adversemedia/analytics");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_18Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v2/businessdocument/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> createSearchResults_22Async(object request)
    {
        var xml = XmlHelper.Serialize(request);
        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("/v3/court/searchResults", content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

}
