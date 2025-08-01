using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CollateralMachineInfo")]
public class CollateralMachineInfo
{
    [XmlElement("TypeOfMachine")]
    public string TypeOfMachine { get; set; }

    [XmlElement("TypeOfSecondaryMachine")]
    public string TypeOfSecondaryMachine { get; set; }

    [XmlElement("Manufacturer")]
    public string Manufacturer { get; set; }

    [XmlElement("ManufacturerYear")]
    public string ManufacturerYear { get; set; }

    [XmlElement("ModelDescription")]
    public string ModelDescription { get; set; }

    [XmlElement("Model")]
    public string Model { get; set; }

    [XmlElement("ModelYear")]
    public string ModelYear { get; set; }

    [XmlElement("ModelStatus")]
    public string ModelStatus { get; set; }

    [XmlElement("Quantity")]
    public string Quantity { get; set; }

    [XmlElement("SerialNumber")]
    public string SerialNumber { get; set; }
}
