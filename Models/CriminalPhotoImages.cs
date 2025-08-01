using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalPhotoImages")]
public class CriminalPhotoImages
{
    [XmlElement("BinaryImage")]
    public string BinaryImage { get; set; }

    [XmlElement("ContentType")]
    public string ContentType { get; set; }

}