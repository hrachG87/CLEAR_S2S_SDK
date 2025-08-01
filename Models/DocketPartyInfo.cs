using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocketPartyInfo")]
public class DocketPartyInfo
{
    [XmlElement("DocketPartyName")]
    public string DocketPartyName { get; set; }

    [XmlElement("DocketPartyType")]
    public string DocketPartyType { get; set; }

}