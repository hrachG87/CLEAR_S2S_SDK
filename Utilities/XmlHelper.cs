using System.IO;
using System.Text;
using System.Xml.Serialization;

public static class XmlHelper
{
    public static string Serialize<T>(T obj)
    {
        var serializer = new XmlSerializer(typeof(T));
        using var sw = new StringWriter();
        serializer.Serialize(sw, obj);
        return sw.ToString();
    }

    public static T Deserialize<T>(string xml)
    {
        var serializer = new XmlSerializer(typeof(T));
        using var sr = new StringReader(xml);
        return (T)serializer.Deserialize(sr);
    }
}
