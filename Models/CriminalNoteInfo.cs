using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalNoteInfo")]
public class CriminalNoteInfo
{
    [XmlElement("Note")]
    public string Note { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}