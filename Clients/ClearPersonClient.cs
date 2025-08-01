using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class ClearPersonClient
{
    private readonly HttpClient _httpClient;

    public ClearPersonClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> SubmitPersonSearchAsync(EIDVPersonSearch request)
    {
        var serializer = new XmlSerializer(typeof(EIDVPersonSearch));
        using var stringWriter = new StringWriter();
        serializer.Serialize(stringWriter, request);
        var xml = stringWriter.ToString();

        var content = new StringContent(xml, Encoding.UTF8, "application/xml");
        var response = await _httpClient.PostAsync("v2/eidvperson/searchResults", content);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}
