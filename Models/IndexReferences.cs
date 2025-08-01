using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("IndexReferences")]
public class IndexReferences
{
    [XmlElement("NewsSubject")]
    public List<string> NewsSubject { get; set; }

    [XmlElement("Company")]
    public List<string> Company { get; set; }

    [XmlElement("Industry")]
    public List<string> Industry { get; set; }

    [XmlElement("Region")]
    public List<string> Region { get; set; }

    [XmlElement("Language")]
    public string Language { get; set; }

    [XmlElement("OtherIndexing")]
    public List<string> OtherIndexing { get; set; }

    [XmlElement("GeographicTerms")]
    public List<string> GeographicTerms { get; set; }

    [XmlElement("Edition")]
    public string Edition { get; set; }

    [XmlElement("KeyWords")]
    public List<string> KeyWords { get; set; }

    [XmlElement("CompanyTerms")]
    public List<string> CompanyTerms { get; set; }

    [XmlElement("LegalTerms")]
    public List<string> LegalTerms { get; set; }

    [XmlElement("SubstanceTerms")]
    public List<string> SubstanceTerms { get; set; }
}
