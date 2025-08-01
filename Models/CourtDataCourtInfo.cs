using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataCourtInfo")]
public class CourtDataCourtInfo
{
    [XmlElement("ConvertDate")]
    public string ConvertDate { get; set; }

    [XmlElement("CourtName")]
    public string CourtName { get; set; }

    [XmlElement("JuryDemand")]
    public string JuryDemand { get; set; }

    [XmlElement("JuryDemandAmount")]
    public string JuryDemandAmount { get; set; }

}
}