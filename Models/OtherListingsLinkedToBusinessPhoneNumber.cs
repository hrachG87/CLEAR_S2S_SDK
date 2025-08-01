using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("OtherListingsLinkedToBusinessPhoneNumber")]
public class OtherListingsLinkedToBusinessPhoneNumber
{
    [XmlElement("OtherListingsLinkedToBusinessPhoneNumberIndicator")]
    public string OtherListingsLinkedToBusinessPhoneNumberIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("OtherListingsLinkedToBusinessPhoneNumberDetails")]
    public List<OtherListingsLinkedToBusinessPhoneNumberDetails> OtherListingsLinkedToBusinessPhoneNumberDetails { get; set; }
}
