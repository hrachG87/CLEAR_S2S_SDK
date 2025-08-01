using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UncategorizedCriminalRecords")]
public class UncategorizedCriminalRecords
{
    [XmlElement("UncategorizedCriminalRecordsFlag")]
    public RiskFlagInfo UncategorizedCriminalRecordsFlag { get; set; }

}