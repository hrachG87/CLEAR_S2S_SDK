using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryCodeViolationCategory")]
public class CriminalCategoryCodeViolationCategory
{
    [XmlElement("HousingCodeViolation")]
    public CriminalChargetypes HousingCodeViolation { get; set; }

    [XmlElement("ZoningCodeViolation")]
    public CriminalChargetypes ZoningCodeViolation { get; set; }

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