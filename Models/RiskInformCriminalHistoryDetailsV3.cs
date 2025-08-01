using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformCriminalHistoryDetailsV3")]
public class RiskInformCriminalHistoryDetailsV3
{
    [XmlElement("criminalHistoryRecord")]
    public CriminalRecordInfoV3 criminalHistoryRecord { get; set; }

}