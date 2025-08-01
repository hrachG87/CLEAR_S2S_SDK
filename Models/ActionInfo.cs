using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ActionInfo")]
public class ActionInfo
{
    [XmlElement("ActionType")]
    public string ActionType { get; set; }

    [XmlElement("ActionTerm")]
    public string ActionTerm { get; set; }

    [XmlElement("ActionCode")]
    public string ActionCode { get; set; }

    [XmlElement("ActionStartDate")]
    public string ActionStartDate { get; set; }

    [XmlElement("ActionEndDate")]
    public string ActionEndDate { get; set; }

}