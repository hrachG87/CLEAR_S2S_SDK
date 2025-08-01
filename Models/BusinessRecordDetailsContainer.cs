using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessRecordDetailsContainer")]
public class BusinessRecordDetailsContainer
{
    [XmlElement("BusinessResponseDetail")]
    public BusinessResponseDetail BusinessResponseDetail { get; set; }
}
