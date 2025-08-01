using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MilitaryRecord")]
public class MilitaryRecord
{
    [XmlElement("ActiveDutyBaseDate")]
    public string ActiveDutyBaseDate { get; set; }

    [XmlElement("CurrentDutyStatus")]
    public string CurrentDutyStatus { get; set; }

    [XmlElement("DutyStationDate")]
    public string DutyStationDate { get; set; }

    [XmlElement("CurrentRetirementDate")]
    public string CurrentRetirementDate { get; set; }

    [XmlElement("EstimatedSeparationDate")]
    public string EstimatedSeparationDate { get; set; }

    [XmlElement("MilitaryAddress")]
    public CommonDataAddress MilitaryAddress { get; set; }

    [XmlElement("MilitaryBranchCode")]
    public string MilitaryBranchCode { get; set; }

    [XmlElement("MilitaryPayGrade")]
    public string MilitaryPayGrade { get; set; }

    [XmlElement("MilitaryRank")]
    public string MilitaryRank { get; set; }

    [XmlElement("OfficerMandatoryRemovalDate")]
    public string OfficerMandatoryRemovalDate { get; set; }

    [XmlElement("OriginalRetirementDate")]
    public string OriginalRetirementDate { get; set; }

    [XmlElement("PayEntryBaseDate")]
    public string PayEntryBaseDate { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonMilitarySummary")]
    public PersonMilitarySummary PersonMilitarySummary { get; set; }

    [XmlElement("ReserveCommitmentExpireDate")]
    public string ReserveCommitmentExpireDate { get; set; }

    [XmlElement("ReserveInitialEntryDate")]
    public string ReserveInitialEntryDate { get; set; }

    [XmlElement("MilitaryOccupationSpecialty")]
    public string MilitaryOccupationSpecialty { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
