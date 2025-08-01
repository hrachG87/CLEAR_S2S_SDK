using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DeceasedRecord")]
public class DeceasedRecord
{
    [XmlElement("AKAInfo")]
    public PersonName AKAInfo { get; set; }

    [XmlElement("AutopsyInd")]
    public string AutopsyInd { get; set; }

    [XmlElement("CauseOfDeath")]
    public string CauseOfDeath { get; set; }

    [XmlElement("DeathCertVolnbr")]
    public string DeathCertVolnbr { get; set; }

    [XmlElement("DeathCertVolyr")]
    public string DeathCertVolyr { get; set; }

    [XmlElement("DeathCertificateNumber")]
    public string DeathCertificateNumber { get; set; }

    [XmlElement("DisposalOfRemains")]
    public string DisposalOfRemains { get; set; }

    [XmlElement("FatherBirthPlace")]
    public string FatherBirthPlace { get; set; }

    [XmlElement("FatherName")]
    public string FatherName { get; set; }

    [XmlElement("LastAddress")]
    public LastAddress LastAddress { get; set; }

    [XmlElement("LocationOfBirth")]
    public CommonDataAddress LocationOfBirth { get; set; }

    [XmlElement("LocationOfDeath")]
    public CommonDataAddress LocationOfDeath { get; set; }

    [XmlElement("MotherBirthPlace")]
    public string MotherBirthPlace { get; set; }

    [XmlElement("MotherName")]
    public string MotherName { get; set; }

    [XmlElement("PersonInfo")]
    public PersonInfo PersonInfo { get; set; }

    [XmlElement("SpouseName")]
    public string SpouseName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}