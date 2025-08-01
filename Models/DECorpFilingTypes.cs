using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DECorpFilingTypes")]
public class DECorpFilingTypes
{
    [XmlElement("ActiveInactiveCompanies")]
    public bool ActiveInactiveCompanies { get; set; }

    [XmlElement("NameReservations")]
    public bool NameReservations { get; set; }

    [XmlElement("PreviousCompanyNames")]
    public bool PreviousCompanyNames { get; set; }

}