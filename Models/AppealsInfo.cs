using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AppealsInfo")]
public class AppealsInfo
{
    [XmlElement("AppealDate")]
    public string AppealDate { get; set; }

    [XmlElement("AppealDescription")]
    public string AppealDescription { get; set; }

    [XmlElement("AppealNotes")]
    public string AppealNotes { get; set; }

    [XmlElement("AppealTitle")]
    public string AppealTitle { get; set; }

    [XmlElement("PartyNumber")]
    public string PartyNumber { get; set; }

    [XmlElement("Disposition")]
    public CaseDisposition Disposition { get; set; }
}
