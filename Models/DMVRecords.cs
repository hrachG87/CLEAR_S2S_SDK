using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DMVRecords")]
public class DMVRecords
{
    [XmlElement("DMVRecordsFlag")]
    public BusinessRiskFlagInfo DMVRecordsFlag { get; set; }

}