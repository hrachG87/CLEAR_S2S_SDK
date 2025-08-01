using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PublicRecordsTampering")]
public class PublicRecordsTampering
{
    [XmlElement("TamperWithPublicRecords")]
    public RiskFlagInfo TamperWithPublicRecords { get; set; }

}