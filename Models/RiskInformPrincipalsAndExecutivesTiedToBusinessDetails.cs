using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPrincipalsAndExecutivesTiedToBusinessDetails")]
public class RiskInformPrincipalsAndExecutivesTiedToBusinessDetails
{
    [XmlElement("principalsExecutivesTiedToBusinessRecord")]
    public PrincipalsExecutivesTiedToBusinessRecord principalsExecutivesTiedToBusinessRecord { get; set; }
}
