using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalRecordInfo")]
public class CriminalRecordInfo
{
    [XmlElement("criminalFlags")]
    public CriminalFlags criminalFlags { get; set; }

    [XmlElement("otherFlags")]
    public OtherFlags otherFlags { get; set; }

    [XmlElement("sourceDocumentsInfo")]
    public List<RIPersonReportSourceDocumentsInfo> sourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}
}