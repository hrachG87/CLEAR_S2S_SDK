using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
