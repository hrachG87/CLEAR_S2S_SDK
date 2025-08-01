using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessAddressUsedAsResidentialAddress")]
public class BusinessAddressUsedAsResidentialAddress
{
    [XmlElement("BusinessAddressUsedAsResidentialAddressIndicator")]
    public string BusinessAddressUsedAsResidentialAddressIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("BusinessUsedAsResidentialAddressDetails")]
    public List<BusinessAddressUsedAsResidentialAddressDetails> BusinessUsedAsResidentialAddressDetails { get; set; }
}
