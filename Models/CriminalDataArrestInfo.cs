using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalDataArrestInfo")]
public class CriminalDataArrestInfo
{
    [XmlElement("AgreementDate")]
    public string AgreementDate { get; set; }

    [XmlElement("AgencyInfo")]
    public List<AgencyInfo> AgencyInfo { get; set; }

    [XmlElement("ArrestCancelDate")]
    public string ArrestCancelDate { get; set; }

    [XmlElement("ArrestDate")]
    public List<string> ArrestDate { get; set; }

    [XmlElement("ArrestLocation")]
    public string ArrestLocation { get; set; }

    [XmlElement("ArrestDisposition")]
    public string ArrestDisposition { get; set; }

    [XmlElement("ArrestNum")]
    public string ArrestNum { get; set; }

    [XmlElement("ArrestWarrantFlag")]
    public string ArrestWarrantFlag { get; set; }

    [XmlElement("BookingInfo")]
    public BookingInfo BookingInfo { get; set; }

    [XmlElement("CountyOfCrime")]
    public string CountyOfCrime { get; set; }

    [XmlElement("TimeOfArrest")]
    public string TimeOfArrest { get; set; }

    [XmlElement("NameUsedAtArrest")]
    public string NameUsedAtArrest { get; set; }

    [XmlElement("ArrestCounty")]
    public string ArrestCounty { get; set; }

}