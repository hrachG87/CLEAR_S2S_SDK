using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryPornographyObsceneMaterial")]
public class CriminalCategoryPornographyObsceneMaterial
{
    [XmlElement("ObsceneMaterialRemarks")]
    public CriminalChargetypes ObsceneMaterialRemarks { get; set; }

    [XmlElement("ManufactureObsceneMaterial")]
    public CriminalChargetypes ManufactureObsceneMaterial { get; set; }

    [XmlElement("SaleObsceneMaterial")]
    public CriminalChargetypes SaleObsceneMaterial { get; set; }

    [XmlElement("MailObsceneMaterial")]
    public CriminalChargetypes MailObsceneMaterial { get; set; }

    [XmlElement("PossessObsceneMaterial")]
    public CriminalChargetypes PossessObsceneMaterial { get; set; }

    [XmlElement("DistrubuteObsceneMaterial")]
    public CriminalChargetypes DistrubuteObsceneMaterial { get; set; }

    [XmlElement("TransportObsceneMaterial")]
    public CriminalChargetypes TransportObsceneMaterial { get; set; }

    [XmlElement("ObsceneCommunication")]
    public CriminalChargetypes ObsceneCommunication { get; set; }

    [XmlElement("Obscenity")]
    public CriminalChargetypes Obscenity { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}