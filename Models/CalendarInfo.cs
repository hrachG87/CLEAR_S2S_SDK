using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CalendarInfo")]
public class CalendarInfo
{
    [XmlElement("EventDate")]
    public string EventDate { get; set; }

    [XmlElement("EventDescription")]
    public string EventDescription { get; set; }

    [XmlElement("EventLocation")]
    public string EventLocation { get; set; }

}