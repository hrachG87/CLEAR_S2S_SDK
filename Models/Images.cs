using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Images")]
public class Images
{
    [XmlElement("BinaryImage")]
    public string BinaryImage { get; set; }

    [XmlElement("ContentType")]
    public string ContentType { get; set; }

    [XmlElement("DataSource")]
    public string DataSource { get; set; }

    [XmlElement("ImageDate")]
    public string ImageDate { get; set; }

}
}