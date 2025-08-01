using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SingleRiskIndicatorsRecord")]
public class SingleRiskIndicatorsRecord
{
    [XmlElement("SourceDocumentsInfo")]
    public List<SourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("SRIFlags")]
    public SingleRiskIndicators SRIFlags { get; set; }

}
}