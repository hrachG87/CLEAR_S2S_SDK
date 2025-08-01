using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIBusinessReportAddressRecord")]
public class RIBusinessReportAddressRecord
{
    [XmlElement("AddressFlags")]
    public AddressFlags AddressFlags { get; set; }

    [XmlElement("SourceDocumentsInfo")]
    public List<SourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}