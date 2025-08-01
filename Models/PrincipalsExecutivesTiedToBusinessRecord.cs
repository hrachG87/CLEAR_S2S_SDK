using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PrincipalsExecutivesTiedToBusinessRecord")]
public class PrincipalsExecutivesTiedToBusinessRecord
{
    [XmlElement("PrincipalsExecutivesTiedToBusinessFlags")]
    public PrincipalsExecutivesTiedToBusiness PrincipalsExecutivesTiedToBusinessFlags { get; set; }

    [XmlElement("SourceDocumentsInfo")]
    public List<SourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }
}
