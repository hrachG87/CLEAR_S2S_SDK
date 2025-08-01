using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformTaxFraudDetails")]
public class RiskInformTaxFraudDetails
{
    [XmlElement("taxFraudRecord")]
    public CriminalRecordInfo taxFraudRecord { get; set; }
}
