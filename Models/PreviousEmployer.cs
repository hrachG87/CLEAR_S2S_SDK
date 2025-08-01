using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PreviousEmployer")]
public class PreviousEmployer
{
    [XmlElement("AddressInfo")]
    public MailingInfo AddressInfo { get; set; }

    [XmlElement("ChangeDate")]
    public string ChangeDate { get; set; }

    [XmlElement("PreviousEmployerName")]
    public string PreviousEmployerName { get; set; }
}
