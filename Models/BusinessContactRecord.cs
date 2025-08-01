using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessContactRecord")]
public class BusinessContactRecord
{
    [XmlElement("IndividualInfo")]
    public BusinessContactRecordIndividualInfo IndividualInfo { get; set; }

    [XmlElement("BusinessInfo")]
    public BusinessContactRecordBusinessInfo BusinessInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}