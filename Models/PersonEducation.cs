using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonEducation")]
public class PersonEducation
{
    [XmlElement("Institution")]
    public string Institution { get; set; }

    [XmlElement("GraduationDate")]
    public string GraduationDate { get; set; }

}