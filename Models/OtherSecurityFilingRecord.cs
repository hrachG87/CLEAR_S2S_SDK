using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherSecurityFilingRecord")]
public class OtherSecurityFilingRecord
{
    [XmlElement("OtherSecuritiesFilings")]
    public List<SECInfo> OtherSecuritiesFilings { get; set; }

}