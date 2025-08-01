using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryTheftShoplifting")]
public class CriminalCategoryTheftShoplifting
{
    [XmlElement("ComputerTheft")]
    public CriminalSubcategoryComputerTheft ComputerTheft { get; set; }

    [XmlElement("PettyTheft")]
    public CriminalSubcategoryPettyTheft PettyTheft { get; set; }

    [XmlElement("PocketPicking")]
    public CriminalSubcategoryPocketPicking PocketPicking { get; set; }

    [XmlElement("PurseSnatching")]
    public CriminalSubcategoryPurseSnatching PurseSnatching { get; set; }

    [XmlElement("Shoplifting")]
    public CriminalSubcategoryShoplifting Shoplifting { get; set; }

    [XmlElement("Theft")]
    public CriminalSubcategoryTheft Theft { get; set; }

    [XmlElement("TheftOfTradeSecrets")]
    public CriminalSubcategoryTheftOfTradeSecrets TheftOfTradeSecrets { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}