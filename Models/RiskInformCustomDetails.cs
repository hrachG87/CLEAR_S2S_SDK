using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformCustomDetails")]
public class RiskInformCustomDetails
{
    [XmlElement("CustomRecord")]
    public BusinessRiskRecord CustomRecord { get; set; }

}