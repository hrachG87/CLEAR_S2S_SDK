using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("InvolvedParty")]
public class InvolvedParty
{
    [XmlElement("AssociatedClaimInfo")]
    public List<ValueAndLabelSet> AssociatedClaimInfo { get; set; }

    [XmlElement("ComplaintCharges")]
    public List<ComplaintCharges> ComplaintCharges { get; set; }

    [XmlElement("InvolvedAttorney")]
    public List<InvolvedAttorney> InvolvedAttorney { get; set; }

    [XmlElement("Miscellaneous")]
    public string Miscellaneous { get; set; }

    [XmlElement("OtherID")]
    public ValueAndLabelSet OtherID { get; set; }

    [XmlElement("OtherInfo")]
    public ValueAndLabelSet OtherInfo { get; set; }

    [XmlElement("ParticipantID")]
    public string ParticipantID { get; set; }

    [XmlElement("PartyEmail")]
    public string PartyEmail { get; set; }

    [XmlElement("PartyNumber")]
    public string PartyNumber { get; set; }

    [XmlElement("PartyTypeAndName")]
    public PartyTypeAndName PartyTypeAndName { get; set; }

    [XmlElement("PendingCharges")]
    public List<CourtDataChargesInfo> PendingCharges { get; set; }

    [XmlElement("PersonInfo")]
    public CourtPersonInfo PersonInfo { get; set; }

    [XmlElement("PrimaryAddress")]
    public CourtDataAddressInfo PrimaryAddress { get; set; }

    [XmlElement("SecondaryAddress")]
    public List<CourtDataAddressInfo> SecondaryAddress { get; set; }

    [XmlElement("TerminatedCharges")]
    public List<CourtDataChargesInfo> TerminatedCharges { get; set; }

    [XmlElement("TerminationData")]
    public string TerminationData { get; set; }

    [XmlElement("DriversLicenseID")]
    public DriverLicenseInfo DriversLicenseID { get; set; }

    [XmlElement("Status")]
    public CourtStatus Status { get; set; }

    [XmlElement("AKAInfo")]
    public CourtDataAKAInfo AKAInfo { get; set; }

}
}