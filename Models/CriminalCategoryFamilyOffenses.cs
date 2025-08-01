using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryFamilyOffenses")]
public class CriminalCategoryFamilyOffenses
{
    [XmlElement("FamilyOffenses")]
    public CriminalSubcategoryFamilyOffenses FamilyOffenses { get; set; }

    [XmlElement("ContributeToDelinquencyOfMinor")]
    public CriminalSubcategoryContributeToDelinquencyOfMinor ContributeToDelinquencyOfMinor { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}