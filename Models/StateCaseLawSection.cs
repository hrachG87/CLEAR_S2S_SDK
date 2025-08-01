using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("StateCaseLawSection")]
public class StateCaseLawSection
{
    [XmlElement("StateCaseLawRecord")]
    public List<StateCaseLawRecord> StateCaseLawRecord { get; set; }

}
}