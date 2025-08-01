using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtPleaInfo")]
public class CourtPleaInfo
{
    [XmlElement("Plea")]
    public string Plea { get; set; }

    [XmlElement("PleaDate")]
    public string PleaDate { get; set; }

    [XmlElement("PleaNumber")]
    public string PleaNumber { get; set; }

    [XmlElement("TypeOfPlea")]
    public string TypeOfPlea { get; set; }

    [XmlElement("partyTypeAndName")]
    public PartyTypeAndName partyTypeAndName { get; set; }

}