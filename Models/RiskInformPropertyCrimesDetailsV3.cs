using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPropertyCrimesDetailsV3")]
public class RiskInformPropertyCrimesDetailsV3
{
    [XmlElement("propertyCrimesRecord")]
    public CriminalRecordInfoV3 propertyCrimesRecord { get; set; }

}
}