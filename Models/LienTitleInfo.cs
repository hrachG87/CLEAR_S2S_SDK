using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LienTitleInfo")]
public class LienTitleInfo
{
    [XmlElement("LienHolderType")]
    public string LienHolderType { get; set; }

    [XmlElement("TitleHolderType")]
    public string TitleHolderType { get; set; }

    [XmlElement("TitleTransferDate")]
    public string TitleTransferDate { get; set; }

    [XmlElement("MailingAddress")]
    public List<CommonDataAddress> MailingAddress { get; set; }

    [XmlElement("PhysicalAddress")]
    public List<CommonDataAddress> PhysicalAddress { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("LienStatus")]
    public string LienStatus { get; set; }
}
