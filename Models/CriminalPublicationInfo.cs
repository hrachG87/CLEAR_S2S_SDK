using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalPublicationInfo")]
public class CriminalPublicationInfo
{
    [XmlElement("PublicationName")]
    public string PublicationName { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Authority")]
    public string Authority { get; set; }
}
