using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryHomicideMurderManslaughter")]
public class CriminalCategoryHomicideMurderManslaughter
{
    [XmlElement("MurderNonNegligentManslaughter")]
    public CriminalSubcategoryMurderNonNegligentManslaughter MurderNonNegligentManslaughter { get; set; }

    [XmlElement("NegligentHomicide")]
    public CriminalSubcategoryNegligentHomicide NegligentHomicide { get; set; }

    [XmlElement("VehicularHomicide")]
    public CriminalSubcategoryVehicularHomicide VehicularHomicide { get; set; }

    [XmlElement("AssistingSuicide")]
    public CriminalSubcategoryAssistingSuicide AssistingSuicide { get; set; }

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