using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DivorceSection")]
public class DivorceSection
{
    [XmlElement("divorceRecord")]
    public List<DivorceRecord> divorceRecord { get; set; }

}
}