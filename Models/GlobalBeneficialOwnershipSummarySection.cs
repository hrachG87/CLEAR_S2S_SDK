using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipSummarySection")]
public class GlobalBeneficialOwnershipSummarySection
{
    [XmlElement("SummaryRecord")]
    public List<GlobalBeneficialOwnershipSummaryRecord> SummaryRecord { get; set; }

}