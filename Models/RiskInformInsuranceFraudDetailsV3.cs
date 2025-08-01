using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformInsuranceFraudDetailsV3")]
public class RiskInformInsuranceFraudDetailsV3
{
    [XmlElement("insuranceFraudRecord")]
    public CriminalRecordInfoV3 insuranceFraudRecord { get; set; }

}