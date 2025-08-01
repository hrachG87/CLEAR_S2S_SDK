using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformPersonUserCriteria")]
public class RiskInformPersonUserCriteria
{
    [XmlElement("RiskInformPersonSearchCriteria")]
    public RiskInformPersonSearchCriteria RiskInformPersonSearchCriteria { get; set; }

}