using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherSecurityFilingRecordSection")]
public class OtherSecurityFilingRecordSection
{
    [XmlElement("OtherSecurityFilingRecord")]
    public List<OtherSecurityFilingRecord> OtherSecurityFilingRecord { get; set; }

}