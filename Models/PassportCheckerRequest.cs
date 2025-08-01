using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PassportCheckerRequest")]
public class PassportCheckerRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("PassportInfo")]
    public PassportInfo PassportInfo { get; set; }

}