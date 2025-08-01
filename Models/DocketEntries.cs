using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocketEntries")]
public class DocketEntries
{
    [XmlElement("EntryNumber")]
    public string EntryNumber { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

}