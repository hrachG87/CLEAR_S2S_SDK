using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessDatasources")]
public class BusinessDatasources
{
    [XmlElement("PublicRecordBusiness")]
    public string PublicRecordBusiness { get; set; }

    [XmlElement("PublicRecordUCCFilings")]
    public string PublicRecordUCCFilings { get; set; }

    [XmlElement("WorldCheckRiskIntelligence")]
    public string WorldCheckRiskIntelligence { get; set; }

    [XmlElement("NPIRecord")]
    public string NPIRecord { get; set; }

}