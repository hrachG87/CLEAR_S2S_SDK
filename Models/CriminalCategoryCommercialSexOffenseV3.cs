using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryCommercialSexOffenseV3")]
public class CriminalCategoryCommercialSexOffenseV3
{
    [XmlElement("HouseIllFame")]
    public CriminalChargetypes HouseIllFame { get; set; }

    [XmlElement("Pimping")]
    public CriminalChargetypes Pimping { get; set; }

    [XmlElement("Prostitution")]
    public CriminalChargetypes Prostitution { get; set; }

    [XmlElement("FrequentHouseIllFame")]
    public CriminalChargetypes FrequentHouseIllFame { get; set; }

    [XmlElement("TransportFemaleForImmoralPurpose")]
    public CriminalChargetypes TransportFemaleForImmoralPurpose { get; set; }

    [XmlElement("ProstitutionProcurementMinor")]
    public CriminalChargetypes ProstitutionProcurementMinor { get; set; }

    [XmlElement("ProstitutionProcurementAdult")]
    public CriminalChargetypes ProstitutionProcurementAdult { get; set; }

    [XmlElement("InterstateTransportForCommSex")]
    public CriminalChargetypes InterstateTransportForCommSex { get; set; }

    [XmlElement("CommercialSex")]
    public CriminalChargetypes CommercialSex { get; set; }

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