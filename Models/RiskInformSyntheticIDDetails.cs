using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformSyntheticIDDetails")]
public class RiskInformSyntheticIDDetails
{
    [XmlElement("syntheticIDRecord")]
    public SyntheticIDRecord syntheticIDRecord { get; set; }

}
}