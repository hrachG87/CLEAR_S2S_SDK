using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryControlledSubstances")]
public class CriminalCategoryControlledSubstances
{
    [XmlElement("ControlledSubstanceManufacture")]
    public CriminalSubcategoryControlledSubstanceManufacture ControlledSubstanceManufacture { get; set; }

    [XmlElement("ControlledSubstanceOffense")]
    public CriminalSubcategoryControlledSubstanceOffense ControlledSubstanceOffense { get; set; }

    [XmlElement("ControlledSubstancePossession")]
    public CriminalSubcategoryControlledSubstancePossession ControlledSubstancePossession { get; set; }

    [XmlElement("ControlledSubstanceSaleDistribution")]
    public CriminalSubcategoryControlledSubstanceSaleDistribution ControlledSubstanceSaleDistribution { get; set; }

    [XmlElement("CounterfeitDrugPossession")]
    public CriminalSubcategoryCounterfeitDrugPossession CounterfeitDrugPossession { get; set; }

    [XmlElement("CounterfeitDrugSaleDistribution")]
    public CriminalSubcategoryCounterfeitDrugSaleDistribution CounterfeitDrugSaleDistribution { get; set; }

    [XmlElement("DeliverControlledSubstanceToMinor")]
    public CriminalSubcategoryDeliverControlledSubstanceToMinor DeliverControlledSubstanceToMinor { get; set; }

    [XmlElement("DrugsFraud")]
    public CriminalSubcategoryDrugsFraud DrugsFraud { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
