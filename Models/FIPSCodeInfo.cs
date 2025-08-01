using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FIPSCodeInfo")]
public class FIPSCodeInfo
{
    [XmlElement("FIPSState")]
    public string FIPSState { get; set; }

    [XmlElement("FIPSCounty")]
    public string FIPSCounty { get; set; }

    [XmlElement("FIPSCountyCode")]
    public string FIPSCountyCode { get; set; }

    [XmlElement("FIPSStateCode")]
    public string FIPSStateCode { get; set; }

    [XmlElement("FIPSSubCode")]
    public string FIPSSubCode { get; set; }
}
