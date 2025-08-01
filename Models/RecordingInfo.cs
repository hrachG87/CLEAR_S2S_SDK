using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RecordingInfo")]
public class RecordingInfo
{
    [XmlElement("DocTypeOfDeed")]
    public List<string> DocTypeOfDeed { get; set; }

    [XmlElement("DocumentNum")]
    public string DocumentNum { get; set; }

    [XmlElement("DocumentYear")]
    public string DocumentYear { get; set; }

    [XmlElement("RecordingBook")]
    public string RecordingBook { get; set; }

    [XmlElement("RecordingBookPage")]
    public string RecordingBookPage { get; set; }

    [XmlElement("RecordingDate")]
    public string RecordingDate { get; set; }

    [XmlElement("TypeOfDocument")]
    public string TypeOfDocument { get; set; }

}