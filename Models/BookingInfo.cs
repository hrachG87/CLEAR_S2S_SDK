using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BookingInfo")]
public class BookingInfo
{
    [XmlElement("BookingDate")]
    public string BookingDate { get; set; }

    [XmlElement("BookingLocation")]
    public string BookingLocation { get; set; }

    [XmlElement("BookingLocationText")]
    public string BookingLocationText { get; set; }

    [XmlElement("BookingNumber")]
    public string BookingNumber { get; set; }

    [XmlElement("BookingTime")]
    public string BookingTime { get; set; }

    [XmlElement("ArrestAgencyInfo")]
    public AgencyInfo ArrestAgencyInfo { get; set; }

    [XmlElement("ArrestDateTime")]
    public string ArrestDateTime { get; set; }

    [XmlElement("OffenseDateTime")]
    public string OffenseDateTime { get; set; }

    [XmlElement("HoldingAgencyInfo")]
    public AgencyInfo HoldingAgencyInfo { get; set; }

    [XmlElement("ParoleClass")]
    public string ParoleClass { get; set; }

    [XmlElement("ReleaseDateTime")]
    public string ReleaseDateTime { get; set; }

    [XmlElement("ReleasedFromSupervision")]
    public string ReleasedFromSupervision { get; set; }

    [XmlElement("ReleaseReason")]
    public string ReleaseReason { get; set; }

    [XmlElement("ScheduledReleaseDate")]
    public string ScheduledReleaseDate { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

}