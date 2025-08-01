using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Summary")]
public class Summary
{
    [XmlElement("BusinessName")]
    public EidvBusinessSearchMatchTypeField BusinessName { get; set; }

    [XmlElement("FeinNumber")]
    public EidvBusinessSearchMatchTypeField FeinNumber { get; set; }

    [XmlElement("CorporationId")]
    public EidvBusinessSearchMatchTypeField CorporationId { get; set; }

    [XmlElement("DunsNumber")]
    public EidvBusinessSearchMatchTypeField DunsNumber { get; set; }

    [XmlElement("Street")]
    public EidvBusinessSearchMatchTypeField Street { get; set; }

    [XmlElement("StreetNumber")]
    public EidvBusinessSearchMatchTypeField StreetNumber { get; set; }

    [XmlElement("StreetName")]
    public EidvBusinessSearchMatchTypeField StreetName { get; set; }

    [XmlElement("City")]
    public EidvBusinessSearchMatchTypeField City { get; set; }

    [XmlElement("State")]
    public EidvBusinessSearchMatchTypeField State { get; set; }

    [XmlElement("Province")]
    public EidvBusinessSearchMatchTypeField Province { get; set; }

    [XmlElement("ZipCode")]
    public EidvBusinessSearchMatchTypeField ZipCode { get; set; }

    [XmlElement("Country")]
    public EidvBusinessSearchMatchTypeField Country { get; set; }

    [XmlElement("PhoneNumber")]
    public EidvBusinessSearchMatchTypeField PhoneNumber { get; set; }

    [XmlElement("OfficerAgentFirstName")]
    public EidvBusinessSearchMatchTypeField OfficerAgentFirstName { get; set; }

    [XmlElement("OfficerAgentMiddleName")]
    public EidvBusinessSearchMatchTypeField OfficerAgentMiddleName { get; set; }

    [XmlElement("OfficerAgentLastName")]
    public EidvBusinessSearchMatchTypeField OfficerAgentLastName { get; set; }

    [XmlElement("NPINumber")]
    public EidvBusinessSearchMatchTypeField NPINumber { get; set; }

}