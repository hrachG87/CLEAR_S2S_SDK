using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EducationSection")]
public class EducationSection
{
    [XmlElement("EducationRecord")]
    public EducationInfo EducationRecord { get; set; }

}