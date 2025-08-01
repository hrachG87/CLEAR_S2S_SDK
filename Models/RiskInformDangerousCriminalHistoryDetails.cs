using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformDangerousCriminalHistoryDetails")]
public class RiskInformDangerousCriminalHistoryDetails
{
    [XmlElement("dangerousHistoryRecord")]
    public CriminalRecordInfo dangerousHistoryRecord { get; set; }
}
