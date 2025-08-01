using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FilingTypeInfo")]
public class FilingTypeInfo
{
    [XmlElement("ActionDescription")]
    public string ActionDescription { get; set; }

    [XmlElement("FileTypeDescription")]
    public string FileTypeDescription { get; set; }

    [XmlElement("TaxDescription")]
    public string TaxDescription { get; set; }

    [XmlElement("TypeofTax")]
    public string TypeofTax { get; set; }

    [XmlElement("FileType")]
    public string FileType { get; set; }

    [XmlElement("TypeOfAction")]
    public List<string> TypeOfAction { get; set; }

}
}