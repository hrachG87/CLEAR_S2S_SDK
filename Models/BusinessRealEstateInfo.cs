using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessRealEstateInfo")]
public class BusinessRealEstateInfo
{
    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("Designation")]
    public string Designation { get; set; }

    [XmlElement("BusinessName")]
    public List<string> BusinessName { get; set; }

    [XmlElement("TaxID")]
    public List<string> TaxID { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

    [XmlElement("realEstateAddress")]
    public CommonDataAddress realEstateAddress { get; set; }
}
