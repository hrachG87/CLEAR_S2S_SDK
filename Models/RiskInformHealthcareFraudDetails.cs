using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformHealthcareFraudDetails")]
public class RiskInformHealthcareFraudDetails
{
    [XmlElement("healthcareFraudRecord")]
    public CriminalRecordInfo healthcareFraudRecord { get; set; }

}