using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SchoolInfo")]
public class SchoolInfo
{
    [XmlElement("CollegeDegree")]
    public CollegeDegree CollegeDegree { get; set; }

    [XmlElement("GraduationDate")]
    public string GraduationDate { get; set; }

    [XmlElement("MedSchoolDates")]
    public string MedSchoolDates { get; set; }

    [XmlElement("SchoolLocation")]
    public string SchoolLocation { get; set; }

    [XmlElement("SchoolName")]
    public string SchoolName { get; set; }

    [XmlElement("TypeOfEducation")]
    public string TypeOfEducation { get; set; }

    [XmlElement("SchoolState")]
    public string SchoolState { get; set; }

    [XmlElement("SchoolEndDate")]
    public string SchoolEndDate { get; set; }

    [XmlElement("SchoolStartDate")]
    public string SchoolStartDate { get; set; }

}