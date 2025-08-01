using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CollateralInfo")]
public class CollateralInfo
{
    [XmlElement("TypeOfCollateral")]
    public string TypeOfCollateral { get; set; }

    [XmlElement("CollateralMachineInfo")]
    public List<CollateralMachineInfo> CollateralMachineInfo { get; set; }

}
}