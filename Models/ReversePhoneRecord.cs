using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ReversePhoneRecord")]
public class ReversePhoneRecord
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AddressType")]
    public string AddressType { get; set; }

    [XmlElement("CarrierRoute")]
    public string CarrierRoute { get; set; }

    [XmlElement("ConsolidatedMetroStatArea")]
    public string ConsolidatedMetroStatArea { get; set; }

    [XmlElement("CongressionalDistrict")]
    public string CongressionalDistrict { get; set; }

    [XmlElement("DeliveryPointCode")]
    public string DeliveryPointCode { get; set; }

    [XmlElement("FedInfoProcessStandardsCode")]
    public string FedInfoProcessStandardsCode { get; set; }

    [XmlElement("LineType")]
    public string LineType { get; set; }

    [XmlElement("ListingCreateDate")]
    public string ListingCreateDate { get; set; }

    [XmlElement("ListingTransDate")]
    public string ListingTransDate { get; set; }

    [XmlElement("ListingType")]
    public string ListingType { get; set; }

    [XmlElement("MatchCode")]
    public string MatchCode { get; set; }

    [XmlElement("MatchScore")]
    public string MatchScore { get; set; }

    [XmlElement("MetroStatArea")]
    public string MetroStatArea { get; set; }

    [XmlElement("OperatingCompany")]
    public OperatingCompany OperatingCompany { get; set; }

    [XmlElement("CheckDigit")]
    public string CheckDigit { get; set; }

    [XmlElement("PortingFlag")]
    public string PortingFlag { get; set; }

    [XmlElement("PublishedIndicator")]
    public string PublishedIndicator { get; set; }

    [XmlElement("HistoricalInformation")]
    public HistoricalInfo HistoricalInformation { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("ResponseType")]
    public string ResponseType { get; set; }

    [XmlElement("ServiceClass")]
    public string ServiceClass { get; set; }

    [XmlElement("SortZone")]
    public string SortZone { get; set; }

    [XmlElement("StatusCode")]
    public string StatusCode { get; set; }

    [XmlElement("StatusCodeValue")]
    public string StatusCodeValue { get; set; }

    [XmlElement("LatitudeDegreeValue")]
    public string LatitudeDegreeValue { get; set; }

    [XmlElement("LongitudeDegreeValue")]
    public string LongitudeDegreeValue { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("PVSDResponseType")]
    public string PVSDResponseType { get; set; }

    [XmlElement("PVSDServiceTypeFlag")]
    public string PVSDServiceTypeFlag { get; set; }

    [XmlElement("PVSDStatusCode")]
    public string PVSDStatusCode { get; set; }

    [XmlElement("PVSDStatusCodeValue")]
    public string PVSDStatusCodeValue { get; set; }

}
}