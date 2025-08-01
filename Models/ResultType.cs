using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ResultType")]
public class ResultType
{
    [XmlElement("value")]
    public List<ResponseValue> value { get; set; }

    [XmlElement("Number")]
    public string Number { get; set; }

}
}