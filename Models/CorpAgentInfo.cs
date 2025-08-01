using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CorpAgentInfo")]
public class CorpAgentInfo
{
    [XmlElement("CorpAgentAddress")]
    public CommonDataAddress CorpAgentAddress { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

}