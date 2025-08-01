using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformFinancialCrimesDetails")]
public class RiskInformFinancialCrimesDetails
{
    [XmlElement("financialCrimesRecord")]
    public CriminalRecordInfo financialCrimesRecord { get; set; }

}