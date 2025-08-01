using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssociateSection")]
public class AssociateSection
{
    [XmlElement("AssociateRecord")]
    public List<AssociateRecord> AssociateRecord { get; set; }

}
}