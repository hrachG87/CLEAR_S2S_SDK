using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessDocumentDominantValues")]
public class BusinessDocumentDominantValues
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("FileState")]
    public string FileState { get; set; }

}