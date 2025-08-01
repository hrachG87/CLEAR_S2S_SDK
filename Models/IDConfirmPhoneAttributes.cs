using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("IDConfirmPhoneAttributes")]
public class IDConfirmPhoneAttributes
{
    [XmlElement("DisconnectedFlag")]
    public DisconnectedFlagAttributes DisconnectedFlag { get; set; }

    [XmlElement("PhoneUserActivityLowFlag")]
    public PhoneUserActivityLowFlagAttributes PhoneUserActivityLowFlag { get; set; }

    [XmlElement("PrepaidServiceFlag")]
    public PrepaidServiceFlagAttributes PrepaidServiceFlag { get; set; }

    [XmlElement("PhoneAttributeDetails")]
    public PhoneAttributes PhoneAttributeDetails { get; set; }

    [XmlElement("VOIPFlag")]
    public VOIPFlagAttributes VOIPFlag { get; set; }
}
