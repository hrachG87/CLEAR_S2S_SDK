using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MotorVehicleServiceAndWarrantyRecord")]
public class MotorVehicleServiceAndWarrantyRecord
{
    [XmlElement("VehicleInfo")]
    public VehicleInfo VehicleInfo { get; set; }

    [XmlElement("VehicleTransactionInfo")]
    public VehicleTransactionInfo VehicleTransactionInfo { get; set; }

    [XmlElement("RegisteredOwnerInfo")]
    public RegisteredOwnerInfo RegisteredOwnerInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}