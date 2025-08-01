using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("USCoastGuardRecord")]
public class USCoastGuardRecord
{
    [XmlElement("HailAddress")]
    public CommonDataAddress HailAddress { get; set; }

    [XmlElement("HailPort")]
    public string HailPort { get; set; }

    [XmlElement("HullBuildAddress")]
    public CommonDataAddress HullBuildAddress { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("RegisteredVessel")]
    public RegisteredVessel RegisteredVessel { get; set; }

    [XmlElement("VesselInfo")]
    public VehicleVesselInfo VesselInfo { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("ITCRegisteredVessel")]
    public ITCRegisteredVessel ITCRegisteredVessel { get; set; }
}
