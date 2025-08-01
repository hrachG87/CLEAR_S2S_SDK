using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AircraftRecord")]
public class AircraftRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AircraftClass")]
    public string AircraftClass { get; set; }

    [XmlElement("AircraftManufacturer")]
    public string AircraftManufacturer { get; set; }

    [XmlElement("AircraftModelNum")]
    public string AircraftModelNum { get; set; }

    [XmlElement("AircraftSeatsNum")]
    public string AircraftSeatsNum { get; set; }

    [XmlElement("AircraftSeriesNum")]
    public string AircraftSeriesNum { get; set; }

    [XmlElement("AircraftSpeed")]
    public string AircraftSpeed { get; set; }

    [XmlElement("AircraftType")]
    public string AircraftType { get; set; }

    [XmlElement("AircraftWeight")]
    public string AircraftWeight { get; set; }

    [XmlElement("AirworthyDate")]
    public string AirworthyDate { get; set; }

    [XmlElement("EngineManufacturer")]
    public string EngineManufacturer { get; set; }

    [XmlElement("EngineModelNum")]
    public string EngineModelNum { get; set; }

    [XmlElement("EngineThrust")]
    public string EngineThrust { get; set; }

    [XmlElement("EngineType")]
    public string EngineType { get; set; }

    [XmlElement("FractionalOwnership")]
    public string FractionalOwnership { get; set; }

    [XmlElement("LastActivityDate")]
    public string LastActivityDate { get; set; }

    [XmlElement("OtherOwner")]
    public List<PersonName> OtherOwner { get; set; }

    [XmlElement("PrimaryOwner")]
    public PersonName PrimaryOwner { get; set; }

    [XmlElement("RegistrationType")]
    public string RegistrationType { get; set; }

    [XmlElement("ItemModelYearDate")]
    public string ItemModelYearDate { get; set; }

    [XmlElement("ItemSerialIdentification")]
    public string ItemSerialIdentification { get; set; }

    [XmlElement("LocaleRegionName")]
    public string LocaleRegionName { get; set; }

    [XmlElement("RegistrationEffectiveDate")]
    public string RegistrationEffectiveDate { get; set; }

    [XmlElement("RegistrationIdentification")]
    public string RegistrationIdentification { get; set; }

    [XmlElement("RegistrationStatus")]
    public string RegistrationStatus { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}