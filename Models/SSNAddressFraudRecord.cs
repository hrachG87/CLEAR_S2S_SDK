using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SSNAddressFraudRecord")]
public class SSNAddressFraudRecord
{
    [XmlElement("AddressAlert")]
    public List<AlertInfo> AddressAlert { get; set; }

    [XmlElement("SSNAlert")]
    public List<AlertInfo> SSNAlert { get; set; }

}
}