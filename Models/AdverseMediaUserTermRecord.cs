using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaUserTermRecord")]
public class AdverseMediaUserTermRecord
{
    [XmlElement("SearchName")]
    public string SearchName { get; set; }

    [XmlElement("SearchKeywords")]
    public string SearchKeywords { get; set; }

    [XmlElement("SanctionSummarySection")]
    public string SanctionSummarySection { get; set; }

    [XmlElement("AdverseMediaSummarySection")]
    public string AdverseMediaSummarySection { get; set; }

    [XmlElement("SearchScope")]
    public string SearchScope { get; set; }

    [XmlElement("SearchAdverseMedia")]
    public string SearchAdverseMedia { get; set; }

    [XmlElement("SearchSanctions")]
    public string SearchSanctions { get; set; }

    [XmlElement("SearchPoliticallyExposedPersons")]
    public string SearchPoliticallyExposedPersons { get; set; }

    [XmlElement("SearchStateOwnedEntities")]
    public string SearchStateOwnedEntities { get; set; }

    [XmlElement("SearchArticleDateStart")]
    public string SearchArticleDateStart { get; set; }

    [XmlElement("SearchArticleDateEnd")]
    public string SearchArticleDateEnd { get; set; }

    [XmlElement("SearchSanctionOverrideList")]
    public SanctionOverrideList SearchSanctionOverrideList { get; set; }

    [XmlElement("PEPSummarySection")]
    public string PEPSummarySection { get; set; }

    [XmlElement("SOESummarySection")]
    public string SOESummarySection { get; set; }
}
