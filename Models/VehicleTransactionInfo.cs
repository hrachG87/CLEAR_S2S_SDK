using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("VehicleTransactionInfo")]
public class VehicleTransactionInfo
{
    [XmlElement("PurchaseType")]
    public string PurchaseType { get; set; }

    [XmlElement("Mileage")]
    public string Mileage { get; set; }

    [XmlElement("LienTitleInfo")]
    public LienTitleInfo LienTitleInfo { get; set; }

}