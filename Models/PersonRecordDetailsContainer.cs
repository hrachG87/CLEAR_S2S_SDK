using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonRecordDetailsContainer")]
public class PersonRecordDetailsContainer
{
    [XmlElement("PersonResponseDetail")]
    public PersonResponseDetail PersonResponseDetail { get; set; }

}
}