using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HigherCourtInfo")]
public class HigherCourtInfo
{
    [XmlElement("CourtOfAppealJurisdiction")]
    public string CourtOfAppealJurisdiction { get; set; }

    [XmlElement("SupremeCourtJurisdiction")]
    public string SupremeCourtJurisdiction { get; set; }

}
}