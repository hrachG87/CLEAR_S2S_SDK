using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessDocumentResponseDetail")]
public class BusinessDocumentResponseDetail
{
    [XmlElement("BusinessPhoneRecord")]
    public List<BusinessPhoneRecord> BusinessPhoneRecord { get; set; }

    [XmlElement("BusinessProfileRecord")]
    public List<BusinessProfileRecord> BusinessProfileRecord { get; set; }

    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }

    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }

    [XmlElement("FederalEmployerIDRecord")]
    public List<FederalEmployerIDRecord> FederalEmployerIDRecord { get; set; }

    [XmlElement("FictitiousBusinessRecord")]
    public List<FictitiousBusinessRecord> FictitiousBusinessRecord { get; set; }

    [XmlElement("GlobalSanctionRecord")]
    public List<GlobalSanctionRecord> GlobalSanctionRecord { get; set; }

    [XmlElement("InfractionRecord")]
    public List<CriminalRecord> InfractionRecord { get; set; }

    [XmlElement("PhoneRecord")]
    public List<PhoneRecord> PhoneRecord { get; set; }

    [XmlElement("WorldbaseRecord")]
    public List<WorldbaseRecord> WorldbaseRecord { get; set; }

    [XmlElement("WorldCheckRecord")]
    public List<WorldCheckRecord> WorldCheckRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

}
}