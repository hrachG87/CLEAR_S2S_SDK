using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ChildPornography")]
public class ChildPornography
{
    [XmlElement("ProvideMinorObsceneMaterial")]
    public RiskFlagInfo ProvideMinorObsceneMaterial { get; set; }

    [XmlElement("PossessChildPorn")]
    public RiskFlagInfo PossessChildPorn { get; set; }

    [XmlElement("ProduceChildPorn")]
    public RiskFlagInfo ProduceChildPorn { get; set; }

    [XmlElement("DistributeSellChildPorn")]
    public RiskFlagInfo DistributeSellChildPorn { get; set; }

    [XmlElement("ChildPornRemarks")]
    public RiskFlagInfo ChildPornRemarks { get; set; }
}
