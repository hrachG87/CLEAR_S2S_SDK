using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonSearchPhotoImages")]
public class PersonSearchPhotoImages
{
    [XmlElement("Photos")]
    public List<Photos> Photos { get; set; }

    [XmlElement("Images")]
    public List<Images> Images { get; set; }

}
}