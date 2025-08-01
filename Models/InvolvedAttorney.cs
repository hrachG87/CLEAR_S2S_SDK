using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("InvolvedAttorney")]
public class InvolvedAttorney
{
    [XmlElement("AtorneyInfo")]
    public AttorneyInfo AtorneyInfo { get; set; }

    [XmlElement("FirmInfo")]
    public FirmInfo FirmInfo { get; set; }

    [XmlElement("OtherInfo")]
    public ValueAndLabelSet OtherInfo { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("Status")]
    public CourtStatus Status { get; set; }
}
