using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LicenseSection")]
public class LicenseSection
{
    [XmlElement("ProfLicenseRecord")]
    public List<ProfLicenseRecord> ProfLicenseRecord { get; set; }

    [XmlElement("HuntFishLicenseRecord")]
    public List<HuntFishLicenseRecord> HuntFishLicenseRecord { get; set; }

    [XmlElement("FirearmsExplosivesLicenseRecord")]
    public List<FirearmsExplosivesLicenseRecord> FirearmsExplosivesLicenseRecord { get; set; }

    [XmlElement("CCWLicenseRecord")]
    public List<CCWLicenseRecord> CCWLicenseRecord { get; set; }
}
