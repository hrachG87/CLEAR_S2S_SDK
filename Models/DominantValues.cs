using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DominantValues")]
public class DominantValues
{
    [XmlElement("BusinessDocumentDominantValues")]
    public BusinessDocumentDominantValues BusinessDocumentDominantValues { get; set; }
}
