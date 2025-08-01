using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PlanInfo")]
public class PlanInfo
{
    [XmlElement("Plan")]
    public List<Plan> Plan { get; set; }

    [XmlElement("PlanDetails")]
    public List<string> PlanDetails { get; set; }

}