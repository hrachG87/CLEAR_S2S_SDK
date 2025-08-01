using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalBeneficialOwnershipSourceDocumentsRecord")]
public class GlobalBeneficialOwnershipSourceDocumentsRecord
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("PublicationName")]
    public string PublicationName { get; set; }

    [XmlElement("PublicationDate")]
    public string PublicationDate { get; set; }

    [XmlElement("SubjectName")]
    public string SubjectName { get; set; }

    [XmlElement("Identifier")]
    public List<GlobalBeneficialOwnershipIdentifier> Identifier { get; set; }

    [XmlElement("Address")]
    public List<GlobalBeneficialOwnershipAddress> Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("Status")]
    public List<GlobalBeneficialOwnershipStatus> Status { get; set; }

    [XmlElement("Relationships")]
    public GlobalBeneficialOwnershipRelationships Relationships { get; set; }
}
