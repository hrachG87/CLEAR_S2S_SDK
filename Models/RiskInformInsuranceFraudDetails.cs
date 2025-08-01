using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformInsuranceFraudDetails")]
public class RiskInformInsuranceFraudDetails
{
    [XmlElement("insuranceFraudRecord")]
    public CriminalRecordInfo insuranceFraudRecord { get; set; }

}