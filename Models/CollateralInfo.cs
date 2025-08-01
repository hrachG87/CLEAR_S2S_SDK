using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CollateralInfo")]
public class CollateralInfo
{
    [XmlElement("TypeOfCollateral")]
    public string TypeOfCollateral { get; set; }

    [XmlElement("CollateralMachineInfo")]
    public List<CollateralMachineInfo> CollateralMachineInfo { get; set; }
}
