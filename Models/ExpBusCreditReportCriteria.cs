using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExpBusCreditReportCriteria")]
public class ExpBusCreditReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

}