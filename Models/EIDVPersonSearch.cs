using System.Xml.Serialization;

[XmlRoot("EIDVPersonSearch", Namespace = "http://clear.thomsonreuters.com/api/eidvperson-search/2.0")]
public class EIDVPersonSearch
{
    [XmlElement("PermissiblePurpose")]
    public string PermissiblePurpose { get; set; }

    [XmlElement("PersonName")]
    public string PersonName { get; set; }

    [XmlElement("Address")]
    public string Address { get; set; }
}
