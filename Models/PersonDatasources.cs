using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDatasources")]
public class PersonDatasources
{
    [XmlElement("PublicRecordPeople")]
    public string PublicRecordPeople { get; set; }

    [XmlElement("WorldCheckRiskIntelligence")]
    public string WorldCheckRiskIntelligence { get; set; }

    [XmlElement("NPIRecord")]
    public string NPIRecord { get; set; }

}