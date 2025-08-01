using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformCompanyDetailsAndStructureDetails")]
public class RiskInformCompanyDetailsAndStructureDetails
{
    [XmlElement("CompanyDetailsStructureRecord")]
    public CompanyDetailsStructureRecord CompanyDetailsStructureRecord { get; set; }

}