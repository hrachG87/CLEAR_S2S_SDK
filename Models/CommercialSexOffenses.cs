using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CommercialSexOffenses")]
public class CommercialSexOffenses
{
    [XmlElement("HouseIllFame")]
    public RiskFlagInfo HouseIllFame { get; set; }

    [XmlElement("Pimping")]
    public RiskFlagInfo Pimping { get; set; }

    [XmlElement("HomosexualProstitution")]
    public RiskFlagInfo HomosexualProstitution { get; set; }

    [XmlElement("Prostitution")]
    public RiskFlagInfo Prostitution { get; set; }

    [XmlElement("FrequentHouseIllFame")]
    public RiskFlagInfo FrequentHouseIllFame { get; set; }

    [XmlElement("TransportFemaleForImmoralPurpose")]
    public RiskFlagInfo TransportFemaleForImmoralPurpose { get; set; }

    [XmlElement("ProstitutionProcurementMinor")]
    public RiskFlagInfo ProstitutionProcurementMinor { get; set; }

    [XmlElement("ProstitutionProcurementAdult")]
    public RiskFlagInfo ProstitutionProcurementAdult { get; set; }

    [XmlElement("InterstateTransportForCommSex")]
    public RiskFlagInfo InterstateTransportForCommSex { get; set; }

    [XmlElement("CommercialSex")]
    public RiskFlagInfo CommercialSex { get; set; }
}
