using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformDangerousCriminalHistoryDetailsV3")]
public class RiskInformDangerousCriminalHistoryDetailsV3
{
    [XmlElement("dangerousHistoryRecord")]
    public CriminalRecordInfoV3 dangerousHistoryRecord { get; set; }

}