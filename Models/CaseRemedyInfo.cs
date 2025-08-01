using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CaseRemedyInfo")]
public class CaseRemedyInfo
{
    [XmlElement("CaseRemedy")]
    public string CaseRemedy { get; set; }

    [XmlElement("CaseRemedyCode")]
    public string CaseRemedyCode { get; set; }

}