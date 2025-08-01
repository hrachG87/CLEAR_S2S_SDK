using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SSNAddressFraudSection")]
public class SSNAddressFraudSection
{
    [XmlElement("SSNAddressFraudRecord")]
    public List<SSNAddressFraudRecord> SSNAddressFraudRecord { get; set; }
}
