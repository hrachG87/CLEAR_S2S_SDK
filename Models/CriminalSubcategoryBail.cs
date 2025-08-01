using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryBail")]
public class CriminalSubcategoryBail
{
    [XmlElement("SecuredBondBail")]
    public CriminalChargetypes SecuredBondBail { get; set; }

    [XmlElement("PersonalRecogBail")]
    public CriminalChargetypes PersonalRecogBail { get; set; }

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