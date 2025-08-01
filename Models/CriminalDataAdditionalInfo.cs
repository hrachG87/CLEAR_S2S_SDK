using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalDataAdditionalInfo")]
public class CriminalDataAdditionalInfo
{
    [XmlElement("DefenseAttorneyList")]
    public List<DefenseAttorneyList> DefenseAttorneyList { get; set; }

    [XmlElement("JudgeName")]
    public List<string> JudgeName { get; set; }

    [XmlElement("OfficerInfo")]
    public List<CriminalOfficerInfo> OfficerInfo { get; set; }

}