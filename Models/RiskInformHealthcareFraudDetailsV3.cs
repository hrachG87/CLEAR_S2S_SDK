using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformHealthcareFraudDetailsV3")]
public class RiskInformHealthcareFraudDetailsV3
{
    [XmlElement("healthcareFraudRecord")]
    public CriminalRecordInfoV3 healthcareFraudRecord { get; set; }

}