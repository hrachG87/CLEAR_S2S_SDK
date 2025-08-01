using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PrincipalsExecutivesTiedToBusiness")]
public class PrincipalsExecutivesTiedToBusiness
{
    [XmlElement("ListOfPrincipalsExecutivesTiedToBusiness")]
    public BusinessRiskFlagInfo ListOfPrincipalsExecutivesTiedToBusiness { get; set; }

}