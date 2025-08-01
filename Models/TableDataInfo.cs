using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TableDataInfo")]
public class TableDataInfo
{
    [XmlElement("Label")]
    public string Label { get; set; }

    [XmlElement("Data")]
    public string Data { get; set; }

}
}