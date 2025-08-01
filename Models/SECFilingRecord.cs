using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SECFilingRecord")]
public class SECFilingRecord
{
    [XmlElement("SECFinancialFilings")]
    public List<SECInfo> SECFinancialFilings { get; set; }

}