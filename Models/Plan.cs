using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Plan")]
public class Plan
{
    [XmlElement("AuthorizedBy")]
    public string AuthorizedBy { get; set; }

    [XmlElement("AuthorizedTitle")]
    public string AuthorizedTitle { get; set; }

    [XmlElement("PlanFilingDate")]
    public string PlanFilingDate { get; set; }

    [XmlElement("PlanStatus")]
    public string PlanStatus { get; set; }

    [XmlElement("PlanStatusDate")]
    public string PlanStatusDate { get; set; }

    [XmlElement("TypeOfAuthorizer")]
    public string TypeOfAuthorizer { get; set; }

}