using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorpAgentInfo")]
public class CorpAgentInfo
{
    [XmlElement("CorpAgentAddress")]
    public CommonDataAddress CorpAgentAddress { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

}
}