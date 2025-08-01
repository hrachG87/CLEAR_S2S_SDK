using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherBusinessesLinkedToTheBusinessAddress")]
public class OtherBusinessesLinkedToTheBusinessAddress
{
    [XmlElement("OtherBusinessesLinkedToTheBusinessAddressIndicator")]
    public string OtherBusinessesLinkedToTheBusinessAddressIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("OtherBusinessesLinkedToTheBusinessAddressDetails")]
    public List<OtherBusinessesLinkedToTheBusinessAddressDetails> OtherBusinessesLinkedToTheBusinessAddressDetails { get; set; }

}