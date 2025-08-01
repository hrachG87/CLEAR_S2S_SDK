using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TheftShoplifting")]
public class TheftShoplifting
{
    [XmlElement("Pocketpicking")]
    public RiskFlagInfo Pocketpicking { get; set; }

    [XmlElement("PurseSnatchNoForce")]
    public RiskFlagInfo PurseSnatchNoForce { get; set; }

    [XmlElement("Shoplifting")]
    public RiskFlagInfo Shoplifting { get; set; }

    [XmlElement("LarcenyVehicleParts")]
    public RiskFlagInfo LarcenyVehicleParts { get; set; }

    [XmlElement("LarcenyAutomobile")]
    public RiskFlagInfo LarcenyAutomobile { get; set; }

    [XmlElement("LarcenyShipment")]
    public RiskFlagInfo LarcenyShipment { get; set; }

    [XmlElement("LarcenyCoinMachine")]
    public RiskFlagInfo LarcenyCoinMachine { get; set; }

    [XmlElement("LarcenyBuilding")]
    public RiskFlagInfo LarcenyBuilding { get; set; }

    [XmlElement("LarcenyYard")]
    public RiskFlagInfo LarcenyYard { get; set; }

    [XmlElement("LarcenyMail")]
    public RiskFlagInfo LarcenyMail { get; set; }

    [XmlElement("LarcenyBankInstitution")]
    public RiskFlagInfo LarcenyBankInstitution { get; set; }

    [XmlElement("LarcenyInterStateShipment")]
    public RiskFlagInfo LarcenyInterStateShipment { get; set; }

    [XmlElement("ObstructCorrespondence")]
    public RiskFlagInfo ObstructCorrespondence { get; set; }

    [XmlElement("TheftUSGovtProperty")]
    public RiskFlagInfo TheftUSGovtProperty { get; set; }

    [XmlElement("LarcenyUSGovtReserve")]
    public RiskFlagInfo LarcenyUSGovtReserve { get; set; }

    [XmlElement("PostalLarceny")]
    public RiskFlagInfo PostalLarceny { get; set; }

    [XmlElement("TheftByCheck")]
    public RiskFlagInfo TheftByCheck { get; set; }

    [XmlElement("Larceny")]
    public RiskFlagInfo Larceny { get; set; }

    [XmlElement("GrandTheftLarceny")]
    public RiskFlagInfo GrandTheftLarceny { get; set; }

    [XmlElement("FirearmTheft")]
    public RiskFlagInfo FirearmTheft { get; set; }

    [XmlElement("PettyTheft")]
    public RiskFlagInfo PettyTheft { get; set; }

    [XmlElement("TradeSecretTheft")]
    public RiskFlagInfo TradeSecretTheft { get; set; }

    [XmlElement("StatePropertyTheft")]
    public RiskFlagInfo StatePropertyTheft { get; set; }

    [XmlElement("TelecomTheft")]
    public RiskFlagInfo TelecomTheft { get; set; }

    [XmlElement("CopyrightedMaterialTheft")]
    public RiskFlagInfo CopyrightedMaterialTheft { get; set; }

    [XmlElement("ComputerDataSoftwareTheft")]
    public RiskFlagInfo ComputerDataSoftwareTheft { get; set; }

}