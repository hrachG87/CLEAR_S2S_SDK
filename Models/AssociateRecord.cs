using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssociateRecord")]
public class AssociateRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("AssociateInfo")]
    public List<AssociateInfo> AssociateInfo { get; set; }

}
}