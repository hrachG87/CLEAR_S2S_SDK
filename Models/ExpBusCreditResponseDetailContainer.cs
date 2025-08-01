using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExpBusCreditResponseDetailContainer")]
public class ExpBusCreditResponseDetailContainer
{
    [XmlElement("ExpBusCreditResponseDetail")]
    public ExpBusCreditResponseDetail ExpBusCreditResponseDetail { get; set; }

}
}