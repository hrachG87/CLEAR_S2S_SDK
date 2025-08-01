using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CCWLicenseRecord")]
public class CCWLicenseRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("ConcealedWeaponPermit")]
    public PermitInfo ConcealedWeaponPermit { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}