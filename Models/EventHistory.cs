using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EventHistory")]
public class EventHistory
{
    [XmlElement("HistoryEventDate")]
    public string HistoryEventDate { get; set; }

    [XmlElement("HistoryEventDescription")]
    public string HistoryEventDescription { get; set; }

    [XmlElement("TypeOfHistoryEvent")]
    public string TypeOfHistoryEvent { get; set; }
}
