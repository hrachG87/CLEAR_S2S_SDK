using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PeopleDataEducationInfo")]
public class PeopleDataEducationInfo
{
    [XmlElement("EducationLevel1")]
    public string EducationLevel1 { get; set; }

    [XmlElement("EducationLevel2")]
    public string EducationLevel2 { get; set; }

}