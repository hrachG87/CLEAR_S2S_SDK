using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseResponseDetail")]
public class LicenseResponseDetail
{
    [XmlElement("DriverLicenseRecord")]
    public List<DriverLicenseRecord> DriverLicenseRecord { get; set; }

    [XmlElement("ProfLicenseRecord")]
    public List<ProfLicenseRecord> ProfLicenseRecord { get; set; }

    [XmlElement("HealthcareLicenseRecord")]
    public List<HealthcareLicenseRecord> HealthcareLicenseRecord { get; set; }

    [XmlElement("UtilityRecord")]
    public List<UtilityRecord> UtilityRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

    [XmlElement("BankAccountHeaderRecord")]
    public List<BankAccountHeaderRecord> BankAccountHeaderRecord { get; set; }

    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

}