using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformGovProcurementFraudDetailsV3")]
public class RiskInformGovProcurementFraudDetailsV3
{
    [XmlElement("govProcurementFraudRecord")]
    public CriminalRecordInfoV3 govProcurementFraudRecord { get; set; }

}