using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPropertyCrimesDetails")]
public class RiskInformPropertyCrimesDetails
{
    [XmlElement("propertyCrimesRecord")]
    public CriminalRecordInfo propertyCrimesRecord { get; set; }

}
}