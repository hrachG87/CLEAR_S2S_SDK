using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessRecordDetailsContainer")]
public class BusinessRecordDetailsContainer
{
    [XmlElement("BusinessResponseDetail")]
    public BusinessResponseDetail BusinessResponseDetail { get; set; }

}
}