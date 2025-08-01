using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformCriminalHistoryDetails")]
public class RiskInformCriminalHistoryDetails
{
    [XmlElement("criminalHistoryRecord")]
    public CriminalRecordInfo criminalHistoryRecord { get; set; }
}
