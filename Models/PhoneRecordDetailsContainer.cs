using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneRecordDetailsContainer")]
public class PhoneRecordDetailsContainer
{
    [XmlElement("PhoneResponseDetail")]
    public PhoneResponseDetail PhoneResponseDetail { get; set; }
}
