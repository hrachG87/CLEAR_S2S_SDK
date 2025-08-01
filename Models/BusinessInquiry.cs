using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessInquiry")]
public class BusinessInquiry
{
    [XmlElement("BusinessCategory")]
    public string BusinessCategory { get; set; }

    [XmlElement("DatesAndCounts")]
    public DatesAndCounts DatesAndCounts { get; set; }

}