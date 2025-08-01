using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportBankruptcySection")]
public class CompanyReportBankruptcySection
{
    [XmlElement("FedDocketBankruptcyRecord")]
    public List<FedDocketBankruptcyRecord> FedDocketBankruptcyRecord { get; set; }

    [XmlElement("PublicBankruptcyRecord")]
    public List<PublicBankruptcyRecord> PublicBankruptcyRecord { get; set; }

    [XmlElement("SuperiorBankruptcyRecord")]
    public List<SuperiorBankruptcyRecord> SuperiorBankruptcyRecord { get; set; }
}
