using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PreviousMaritalInfo")]
public class PreviousMaritalInfo
{
    [XmlElement("PreviousMaritalStatus")]
    public string PreviousMaritalStatus { get; set; }

    [XmlElement("MarriageEndDate")]
    public string MarriageEndDate { get; set; }
}
