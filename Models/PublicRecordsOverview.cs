using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PublicRecordsOverview")]
public class PublicRecordsOverview
{
    [XmlElement("GeneralInformation")]
    public List<string> GeneralInformation { get; set; }

    [XmlElement("GovernmentActivity")]
    public GovernmentActivity GovernmentActivity { get; set; }

    [XmlElement("CorporateRegistrationInformation")]
    public CorporateRegistrationInformation CorporateRegistrationInformation { get; set; }
}
