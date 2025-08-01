using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicensePublicationInfo")]
public class LicensePublicationInfo
{
    [XmlElement("PublicationName")]
    public string PublicationName { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Authority")]
    public string Authority { get; set; }

}