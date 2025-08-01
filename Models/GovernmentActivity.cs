using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GovernmentActivity")]
public class GovernmentActivity
{
    [XmlElement("Borrower")]
    public string Borrower { get; set; }

    [XmlElement("Contractor")]
    public string Contractor { get; set; }

    [XmlElement("PartyExclusion")]
    public string PartyExclusion { get; set; }

    [XmlElement("AdministrativeDebt")]
    public string AdministrativeDebt { get; set; }

    [XmlElement("Grantee")]
    public string Grantee { get; set; }

}