using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalDataCaseFiling")]
public class CriminalDataCaseFiling
{
    [XmlElement("FileNumber")]
    public string FileNumber { get; set; }

    [XmlElement("FiledDate")]
    public string FiledDate { get; set; }
}
