using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportSingleRiskIndicatorsRecord")]
public class RIPersonReportSingleRiskIndicatorsRecord
{
    [XmlElement("SourceDocumentsInfo")]
    public List<RIPersonReportSourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("sriflags")]
    public SingleRiskIndicators sriflags { get; set; }

}
}