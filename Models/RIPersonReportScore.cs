using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonReportScore")]
public class RIPersonReportScore
{
    [XmlElement("riskInformScoreRecord")]
    public RIPersonReportScoreRecord riskInformScoreRecord { get; set; }

}