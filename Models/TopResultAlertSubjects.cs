using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TopResultAlertSubjects")]
public class TopResultAlertSubjects
{
    [XmlElement("TopResultAlertSubject")]
    public List<TopResultAlertSubject> TopResultAlertSubject { get; set; }
}
