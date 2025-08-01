using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryDrugs")]
public class CriminalCategoryDrugs
{
    [XmlElement("ManufactureSellDistribute")]
    public CriminalSubcategoryManufactureSellDistribute ManufactureSellDistribute { get; set; }

    [XmlElement("DrugsOtherOffense")]
    public CriminalSubcategoryDrugsOtherOffense DrugsOtherOffense { get; set; }

    [XmlElement("Possession")]
    public CriminalSubcategoryPossession Possession { get; set; }

    [XmlElement("ParaphernaliaPossession")]
    public CriminalSubcategoryParaphernaliaPossession ParaphernaliaPossession { get; set; }

    [XmlElement("Barbiturates")]
    public CriminalSubcategoryBarbiturates Barbiturates { get; set; }

    [XmlElement("Amphetamine")]
    public CriminalChargetypes Amphetamine { get; set; }

    [XmlElement("DangerousDrugs")]
    public CriminalChargetypes DangerousDrugs { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
