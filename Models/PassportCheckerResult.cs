using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PassportCheckerResult")]
public class PassportCheckerResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("PassportCheckerResult")]
    public PassportCheckerResponse PassportCheckerResult { get; set; }
}
