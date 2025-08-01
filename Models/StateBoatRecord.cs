using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StateBoatRecord")]
public class StateBoatRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("DPPA")]
    public string DPPA { get; set; }

    [XmlElement("VesselInfo")]
    public VehicleVesselInfo VesselInfo { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}