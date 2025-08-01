using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportExecutiveAffiliationSection")]
public class PersonReportExecutiveAffiliationSection
{
    [XmlElement("BusinessPhoneRecord")]
    public List<BusinessPhoneRecord> BusinessPhoneRecord { get; set; }

    [XmlElement("CanadianBusinessPhoneRecord")]
    public List<BusinessPhoneRecord> CanadianBusinessPhoneRecord { get; set; }

    [XmlElement("FictitiousBusinessRecord")]
    public List<FictitiousBusinessRecord> FictitiousBusinessRecord { get; set; }

    [XmlElement("ExecutiveAffiliationRecord")]
    public List<ExecutiveAffiliationRecord> ExecutiveAffiliationRecord { get; set; }

    [XmlElement("ExecutiveBioRecord")]
    public List<ExecutiveBioRecord> ExecutiveBioRecord { get; set; }

    [XmlElement("ExecutiveProfileRecord")]
    public List<ExecutiveProfileRecord> ExecutiveProfileRecord { get; set; }

    [XmlElement("FederalEmployerIDRecord")]
    public List<FederalEmployerIDRecord> FederalEmployerIDRecord { get; set; }

}
}