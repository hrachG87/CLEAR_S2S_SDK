using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformTaxFraudDetailsV3")]
public class RiskInformTaxFraudDetailsV3
{
    [XmlElement("taxFraudRecord")]
    public CriminalRecordInfoV3 taxFraudRecord { get; set; }

}