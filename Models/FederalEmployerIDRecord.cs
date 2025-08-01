using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FederalEmployerIDRecord")]
public class FederalEmployerIDRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("ExecutiveInfo")]
    public ExecutiveInfo ExecutiveInfo { get; set; }

    [XmlElement("BusinessContacts")]
    public BusinessContacts BusinessContacts { get; set; }

    [XmlElement("ParentCompanyName")]
    public string ParentCompanyName { get; set; }

    [XmlElement("SourceOfInformation")]
    public string SourceOfInformation { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}