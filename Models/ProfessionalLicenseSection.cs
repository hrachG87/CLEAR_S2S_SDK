using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ProfessionalLicenseSection")]
public class ProfessionalLicenseSection
{
    [XmlElement("ProfLicenseRecord")]
    public List<ProfLicenseRecord> ProfLicenseRecord { get; set; }

}