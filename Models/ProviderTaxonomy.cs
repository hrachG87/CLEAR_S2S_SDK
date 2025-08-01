using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ProviderTaxonomy")]
public class ProviderTaxonomy
{
    [XmlElement("PrimaryTaxonomy")]
    public string PrimaryTaxonomy { get; set; }

    [XmlElement("TaxonomyClass")]
    public string TaxonomyClass { get; set; }

    [XmlElement("TaxonomyCode")]
    public string TaxonomyCode { get; set; }

    [XmlElement("TaxonomyProvider")]
    public string TaxonomyProvider { get; set; }

    [XmlElement("TaxonomySpecialty")]
    public string TaxonomySpecialty { get; set; }

    [XmlElement("LicenseNumber")]
    public string LicenseNumber { get; set; }

    [XmlElement("LicenseState")]
    public string LicenseState { get; set; }

}
}