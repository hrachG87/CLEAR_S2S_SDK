using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WatercraftDatasources")]
public class WatercraftDatasources
{
    [XmlElement("PublicRecordWatercraft")]
    public string PublicRecordWatercraft { get; set; }

}
}