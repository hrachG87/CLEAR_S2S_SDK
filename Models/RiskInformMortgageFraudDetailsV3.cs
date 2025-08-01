using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformMortgageFraudDetailsV3")]
public class RiskInformMortgageFraudDetailsV3
{
    [XmlElement("mortgageFraudRecord")]
    public CriminalRecordInfoV3 mortgageFraudRecord { get; set; }
}
