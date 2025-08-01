using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataArrestInfo")]
public class CourtDataArrestInfo
{
    [XmlElement("ArrestAgency")]
    public string ArrestAgency { get; set; }

    [XmlElement("ArrestDescAndDate")]
    public ValueAndLabelSet ArrestDescAndDate { get; set; }

    [XmlElement("BookingOrWarrantNum")]
    public string BookingOrWarrantNum { get; set; }

    [XmlElement("NameUsedAtArrest")]
    public ValueAndLabelSet NameUsedAtArrest { get; set; }

    [XmlElement("OffenseCommitted")]
    public string OffenseCommitted { get; set; }

    [XmlElement("OutstandingArrestWarrant")]
    public string OutstandingArrestWarrant { get; set; }

    [XmlElement("Disposition")]
    public CaseDisposition Disposition { get; set; }

    [XmlElement("WarrantDescAndDate")]
    public ValueAndLabelSet WarrantDescAndDate { get; set; }

}
}