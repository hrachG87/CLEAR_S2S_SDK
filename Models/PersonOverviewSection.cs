using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonOverviewSection")]
public class PersonOverviewSection
{
    [XmlElement("PersonOverviewRecord")]
    public PersonOverviewInfo PersonOverviewRecord { get; set; }

}