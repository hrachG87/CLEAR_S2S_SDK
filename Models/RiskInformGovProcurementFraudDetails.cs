using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformGovProcurementFraudDetails")]
public class RiskInformGovProcurementFraudDetails
{
    [XmlElement("govProcurementFraudRecord")]
    public CriminalRecordInfo govProcurementFraudRecord { get; set; }

}