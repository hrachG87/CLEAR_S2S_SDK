using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalDataCaseFiling")]
public class CriminalDataCaseFiling
{
    [XmlElement("FileNumber")]
    public string FileNumber { get; set; }

    [XmlElement("FiledDate")]
    public string FiledDate { get; set; }

}
}