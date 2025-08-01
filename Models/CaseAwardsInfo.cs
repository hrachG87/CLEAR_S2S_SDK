using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CaseAwardsInfo")]
public class CaseAwardsInfo
{
    [XmlElement("AwardAmount")]
    public string AwardAmount { get; set; }

    [XmlElement("AwardType")]
    public string AwardType { get; set; }

}