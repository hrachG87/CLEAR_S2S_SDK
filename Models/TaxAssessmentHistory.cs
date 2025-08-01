using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TaxAssessmentHistory")]
public class TaxAssessmentHistory
{
    [XmlElement("AssessorParcelNumInfo")]
    public AssessorParcelNumInfo AssessorParcelNumInfo { get; set; }

    [XmlElement("HomesteadExemption")]
    public string HomesteadExemption { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("OwnershipInfo")]
    public OwnershipInfo OwnershipInfo { get; set; }

    [XmlElement("PropertyAddress")]
    public CommonDataAddress PropertyAddress { get; set; }

    [XmlElement("TaxAssessorInfo")]
    public TaxAssessorInfo TaxAssessorInfo { get; set; }

}