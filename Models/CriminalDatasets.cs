using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalDatasets")]
public class CriminalDatasets
{
    [XmlElement("CriminalAndCourt")]
    public string CriminalAndCourt { get; set; }

    [XmlElement("ArrestRecords")]
    public string ArrestRecords { get; set; }

}
}