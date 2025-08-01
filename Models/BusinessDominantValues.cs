using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessDominantValues")]
public class BusinessDominantValues
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