using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertyDatasources")]
public class RealPropertyDatasources
{
    [XmlElement("PublicRecordRealProperty")]
    public string PublicRecordRealProperty { get; set; }

}
}