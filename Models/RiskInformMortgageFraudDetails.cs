using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformMortgageFraudDetails")]
public class RiskInformMortgageFraudDetails
{
    [XmlElement("mortgageFraudRecord")]
    public CriminalRecordInfo mortgageFraudRecord { get; set; }
}
