using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
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
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}