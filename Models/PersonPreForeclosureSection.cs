using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonPreForeclosureSection")]
public class PersonPreForeclosureSection
{
    [XmlElement("ForeclosureRecord")]
    public List<ForeclosureRecord> ForeclosureRecord { get; set; }

}