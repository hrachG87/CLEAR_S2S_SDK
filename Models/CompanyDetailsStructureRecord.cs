using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyDetailsStructureRecord")]
public class CompanyDetailsStructureRecord
{
    [XmlElement("CompanyDetailsStructureFlags")]
    public CompanyDetailsStructure CompanyDetailsStructureFlags { get; set; }

    [XmlElement("SourceDocumentsInfo")]
    public List<SourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }
}
