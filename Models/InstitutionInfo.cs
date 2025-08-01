using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("InstitutionInfo")]
public class InstitutionInfo
{
    [XmlElement("AdditionalInstitution")]
    public AdditionalInstitution AdditionalInstitution { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AdmissionInfo")]
    public AdmissionInfo AdmissionInfo { get; set; }

    [XmlElement("ClassAtEscape")]
    public string ClassAtEscape { get; set; }

    [XmlElement("EscapeDate")]
    public string EscapeDate { get; set; }

    [XmlElement("EscapedFacility")]
    public string EscapedFacility { get; set; }

    [XmlElement("EscapeHistoryDesc")]
    public string EscapeHistoryDesc { get; set; }

    [XmlElement("EscapeRecaptureDate")]
    public string EscapeRecaptureDate { get; set; }

    [XmlElement("GainTime")]
    public string GainTime { get; set; }

    [XmlElement("GainTimeEffectiveDate")]
    public string GainTimeEffectiveDate { get; set; }

    [XmlElement("InmateCellNumber")]
    public string InmateCellNumber { get; set; }

    [XmlElement("InmateNumber")]
    public string InmateNumber { get; set; }

    [XmlElement("InmateStatus")]
    public string InmateStatus { get; set; }

    [XmlElement("InmateCustodyClass")]
    public string InmateCustodyClass { get; set; }

    [XmlElement("LastMoveOrTransfer")]
    public string LastMoveOrTransfer { get; set; }

    [XmlElement("LastMoveOrTransferDate")]
    public string LastMoveOrTransferDate { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("SpecialProvision")]
    public string SpecialProvision { get; set; }

    [XmlElement("SpecialProvisionDate")]
    public string SpecialProvisionDate { get; set; }

    [XmlElement("TimeServedCredit")]
    public string TimeServedCredit { get; set; }

}