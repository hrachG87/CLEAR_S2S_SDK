using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryTheft")]
public class CriminalSubcategoryTheft
{
    [XmlElement("LarcenyVehicleParts")]
    public CriminalChargetypes LarcenyVehicleParts { get; set; }

    [XmlElement("LarcenyAutomobile")]
    public CriminalChargetypes LarcenyAutomobile { get; set; }

    [XmlElement("LarcenyShipment")]
    public CriminalChargetypes LarcenyShipment { get; set; }

    [XmlElement("LarcenyCoinMachine")]
    public CriminalChargetypes LarcenyCoinMachine { get; set; }

    [XmlElement("LarcenyBuilding")]
    public CriminalChargetypes LarcenyBuilding { get; set; }

    [XmlElement("LarcenyYard")]
    public CriminalChargetypes LarcenyYard { get; set; }

    [XmlElement("LarcenyMail")]
    public CriminalChargetypes LarcenyMail { get; set; }

    [XmlElement("LarcenyBankInstitution")]
    public CriminalChargetypes LarcenyBankInstitution { get; set; }

    [XmlElement("LarcenyInterStateShipment")]
    public CriminalChargetypes LarcenyInterStateShipment { get; set; }

    [XmlElement("ObstructCorrespondence")]
    public CriminalChargetypes ObstructCorrespondence { get; set; }

    [XmlElement("TheftUSGovtProperty")]
    public CriminalChargetypes TheftUSGovtProperty { get; set; }

    [XmlElement("LarcenyUSGovtReserve")]
    public CriminalChargetypes LarcenyUSGovtReserve { get; set; }

    [XmlElement("GrandTheftLarceny")]
    public CriminalChargetypes GrandTheftLarceny { get; set; }

    [XmlElement("FirearmTheft")]
    public CriminalChargetypes FirearmTheft { get; set; }

    [XmlElement("StatePropertyTheft")]
    public CriminalChargetypes StatePropertyTheft { get; set; }

    [XmlElement("PostalLarceny")]
    public CriminalChargetypes PostalLarceny { get; set; }

    [XmlElement("TheftByCheck")]
    public CriminalChargetypes TheftByCheck { get; set; }

    [XmlElement("TelecomTheft")]
    public CriminalChargetypes TelecomTheft { get; set; }

    [XmlElement("CopyrightedMaterialTheft")]
    public CriminalChargetypes CopyrightedMaterialTheft { get; set; }

    [XmlElement("Larceny")]
    public CriminalChargetypes Larceny { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}