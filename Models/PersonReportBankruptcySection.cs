using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportBankruptcySection")]
public class PersonReportBankruptcySection
{
    [XmlElement("FedDocketBankruptcyRecord")]
    public List<FedDocketBankruptcyRecord> FedDocketBankruptcyRecord { get; set; }

    [XmlElement("PublicBankruptcyRecord")]
    public List<PublicBankruptcyRecord> PublicBankruptcyRecord { get; set; }

    [XmlElement("SuperiorBankruptcy")]
    public List<SuperiorBankruptcyRecord> SuperiorBankruptcy { get; set; }

}