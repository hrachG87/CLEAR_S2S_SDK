using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SSNAddressFraudSection")]
public class SSNAddressFraudSection
{
    [XmlElement("SSNAddressFraudRecord")]
    public List<SSNAddressFraudRecord> SSNAddressFraudRecord { get; set; }

}
}