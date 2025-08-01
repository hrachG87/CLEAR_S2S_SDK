using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExecutiveBioRecord")]
public class ExecutiveBioRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("PersonInfo")]
    public BusinessPersonInfo PersonInfo { get; set; }

    [XmlElement("ExecBiography")]
    public string ExecBiography { get; set; }

    [XmlElement("MgmtResponsibilityDesc")]
    public List<string> MgmtResponsibilityDesc { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("CEODesc")]
    public string CEODesc { get; set; }

}