using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformFinancialCrimesDetailsV3")]
public class RiskInformFinancialCrimesDetailsV3
{
    [XmlElement("financialCrimesRecord")]
    public CriminalRecordInfoV3 financialCrimesRecord { get; set; }

}