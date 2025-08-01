using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("HigherCourtInfo")]
public class HigherCourtInfo
{
    [XmlElement("CourtOfAppealJurisdiction")]
    public string CourtOfAppealJurisdiction { get; set; }

    [XmlElement("SupremeCourtJurisdiction")]
    public string SupremeCourtJurisdiction { get; set; }

}