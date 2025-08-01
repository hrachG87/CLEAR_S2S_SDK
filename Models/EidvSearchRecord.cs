using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvSearchRecord")]
public class EidvSearchRecord
{
    [XmlElement("ContentSource")]
    public string ContentSource { get; set; }

    [XmlElement("ContentScore")]
    public string ContentScore { get; set; }

    [XmlElement("DocumentIdentifier")]
    public string DocumentIdentifier { get; set; }

    [XmlElement("FirstName")]
    public EidvPersonSearchMatchTypeField FirstName { get; set; }

    [XmlElement("MiddleName")]
    public EidvPersonSearchMatchTypeField MiddleName { get; set; }

    [XmlElement("LastName")]
    public EidvPersonSearchMatchTypeField LastName { get; set; }

    [XmlElement("BirthDate")]
    public EidvPersonSearchMatchTypeField BirthDate { get; set; }

    [XmlElement("SSN")]
    public EidvPersonSearchMatchTypeField SSN { get; set; }

    [XmlElement("DriversLicense")]
    public EidvPersonSearchMatchTypeField DriversLicense { get; set; }

    [XmlElement("Street")]
    public EidvPersonSearchMatchTypeField Street { get; set; }

    [XmlElement("StreetNumber")]
    public EidvPersonSearchMatchTypeField StreetNumber { get; set; }

    [XmlElement("StreetName")]
    public EidvPersonSearchMatchTypeField StreetName { get; set; }

    [XmlElement("City")]
    public EidvPersonSearchMatchTypeField City { get; set; }

    [XmlElement("State")]
    public EidvPersonSearchMatchTypeField State { get; set; }

    [XmlElement("ZipCode")]
    public EidvPersonSearchMatchTypeField ZipCode { get; set; }

    [XmlElement("PhoneNumber")]
    public EidvPersonSearchMatchTypeField PhoneNumber { get; set; }

    [XmlElement("NPINumber")]
    public EidvPersonSearchMatchTypeField NPINumber { get; set; }
}
