using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HeaderInfo")]
public class HeaderInfo
{
    [XmlElement("Label")]
    public string Label { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("TableData")]
    public List<TableDataInfo> TableData { get; set; }

}
}