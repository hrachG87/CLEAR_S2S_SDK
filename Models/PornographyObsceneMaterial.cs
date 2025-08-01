using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PornographyObsceneMaterial")]
public class PornographyObsceneMaterial
{
    [XmlElement("ObsceneMaterialRemarks")]
    public RiskFlagInfo ObsceneMaterialRemarks { get; set; }

    [XmlElement("ManufactureObsceneMaterial")]
    public RiskFlagInfo ManufactureObsceneMaterial { get; set; }

    [XmlElement("SaleObscenematerial")]
    public RiskFlagInfo SaleObscenematerial { get; set; }

    [XmlElement("MailObsceneMaterial")]
    public RiskFlagInfo MailObsceneMaterial { get; set; }

    [XmlElement("PossessObsceneMaterial")]
    public RiskFlagInfo PossessObsceneMaterial { get; set; }

    [XmlElement("DistributeObsceneMaterial")]
    public RiskFlagInfo DistributeObsceneMaterial { get; set; }

    [XmlElement("TransportObsceneMaterial")]
    public RiskFlagInfo TransportObsceneMaterial { get; set; }

    [XmlElement("ObsceneCommunication")]
    public RiskFlagInfo ObsceneCommunication { get; set; }

    [XmlElement("Obscenity")]
    public RiskFlagInfo Obscenity { get; set; }

}