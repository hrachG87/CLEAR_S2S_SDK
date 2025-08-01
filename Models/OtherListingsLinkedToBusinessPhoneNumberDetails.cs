using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherListingsLinkedToBusinessPhoneNumberDetails")]
public class OtherListingsLinkedToBusinessPhoneNumberDetails
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

}