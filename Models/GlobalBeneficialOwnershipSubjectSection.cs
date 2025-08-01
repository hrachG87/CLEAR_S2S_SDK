using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipSubjectSection")]
public class GlobalBeneficialOwnershipSubjectSection
{
    [XmlElement("SubjectRecord")]
    public GlobalBeneficialOwnershipEntityDetail SubjectRecord { get; set; }

}