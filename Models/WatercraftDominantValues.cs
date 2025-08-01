using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WatercraftDominantValues")]
public class WatercraftDominantValues
{
    [XmlElement("VesselName")]
    public string VesselName { get; set; }

    [XmlElement("VesselHullID")]
    public string VesselHullID { get; set; }

    [XmlElement("OwnerName")]
    public string OwnerName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("RegistrationEffectiveDate")]
    public string RegistrationEffectiveDate { get; set; }

}