using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonRecordDetailsContainer")]
public class PersonRecordDetailsContainer
{
    [XmlElement("PersonResponseDetail")]
    public PersonResponseDetail PersonResponseDetail { get; set; }

}