using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalPersonMilitarySummary")]
public class CriminalPersonMilitarySummary
{
    [XmlElement("BranchName")]
    public string BranchName { get; set; }

    [XmlElement("DischargeCategory")]
    public string DischargeCategory { get; set; }

    [XmlElement("DischargeDate")]
    public string DischargeDate { get; set; }

}