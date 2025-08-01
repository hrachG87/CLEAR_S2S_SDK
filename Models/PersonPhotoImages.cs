using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonPhotoImages")]
public class PersonPhotoImages
{
    [XmlElement("PhotoURL")]
    public List<string> PhotoURL { get; set; }

    [XmlElement("Images")]
    public List<PersonReportImageInfo> Images { get; set; }

}
}