using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AlertSubjects")]
public class AlertSubjects
{
    [XmlElement("AlertSubject")]
    public List<AlertSubject> AlertSubject { get; set; }

}