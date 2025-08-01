using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryBribery")]
public class CriminalSubcategoryBribery
{
    [XmlElement("GivingBribe")]
    public CriminalChargetypes GivingBribe { get; set; }

    [XmlElement("OfferingBribe")]
    public CriminalChargetypes OfferingBribe { get; set; }

    [XmlElement("ReceivingBribe")]
    public CriminalChargetypes ReceivingBribe { get; set; }

    [XmlElement("Bribe")]
    public CriminalChargetypes Bribe { get; set; }

    [XmlElement("GivingGratuity")]
    public CriminalChargetypes GivingGratuity { get; set; }

    [XmlElement("OfferingGratuity")]
    public CriminalChargetypes OfferingGratuity { get; set; }

    [XmlElement("ReceivingGratuity")]
    public CriminalChargetypes ReceivingGratuity { get; set; }

    [XmlElement("Gratuity")]
    public CriminalChargetypes Gratuity { get; set; }

    [XmlElement("GivingKickback")]
    public CriminalChargetypes GivingKickback { get; set; }

    [XmlElement("OfferingKickback")]
    public CriminalChargetypes OfferingKickback { get; set; }

    [XmlElement("ReceivingKickback")]
    public CriminalChargetypes ReceivingKickback { get; set; }

    [XmlElement("Kickback")]
    public CriminalChargetypes Kickback { get; set; }

    [XmlElement("Bribery")]
    public CriminalChargetypes Bribery { get; set; }

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