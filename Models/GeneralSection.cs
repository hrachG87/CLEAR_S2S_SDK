using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GeneralSection")]
public class GeneralSection
{
    [XmlElement("GeneralInfoRecord")]
    public List<GeneralInfoRecord> GeneralInfoRecord { get; set; }

}
}