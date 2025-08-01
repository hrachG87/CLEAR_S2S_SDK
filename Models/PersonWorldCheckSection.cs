using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonWorldCheckSection")]
public class PersonWorldCheckSection
{
    [XmlElement("worldCheckRecord")]
    public List<WorldCheckRecord> worldCheckRecord { get; set; }

}
}