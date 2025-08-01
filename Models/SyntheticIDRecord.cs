using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SyntheticIDRecord")]
public class SyntheticIDRecord
{
    [XmlElement("syntheticIDFlags")]
    public SyntheticIdentity syntheticIDFlags { get; set; }

    [XmlElement("SourceDocumentsInfo")]
    public List<RIPersonReportSourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}
}