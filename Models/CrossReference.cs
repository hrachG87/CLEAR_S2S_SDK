using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CrossReference")]
public class CrossReference
{
    [XmlElement("RefCityRegisterFileNumber")]
    public string RefCityRegisterFileNumber { get; set; }

    [XmlElement("RefDocumentID")]
    public string RefDocumentID { get; set; }

    [XmlElement("RefFileNumber")]
    public string RefFileNumber { get; set; }

}
}