using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TopResultAlertSubject")]
public class TopResultAlertSubject
{
    [XmlElement("AlertSubjectName")]
    public string AlertSubjectName { get; set; }

    [XmlElement("ResultCount")]
    public int ResultCount { get; set; }

}