using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AddressRecord")]
public class AddressRecord
{
    [XmlElement("addressFlags")]
    public PersonAddressFlags addressFlags { get; set; }

    [XmlElement("SourceDocumentsInfo")]
    public List<RIPersonReportSourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}
}